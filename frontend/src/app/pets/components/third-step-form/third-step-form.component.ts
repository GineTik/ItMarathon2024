import { AfterViewInit, Component, DestroyRef, inject, input, OnInit, output, Signal, signal } from '@angular/core';
import { NgClass } from '@angular/common';
import { FormArray, FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { takeUntilDestroyed } from '@angular/core/rxjs-interop';
import { CdkDragDrop, CdkDropList, CdkDrag, DragDropModule, moveItemInArray } from '@angular/cdk/drag-drop';
import { filter, switchMap, tap } from 'rxjs';

import { INPUT_LABELS, PLACEHOLDERS } from '../../../app.config';
import { SelectComponent } from '../../../shared/components/select/select.component';
import { TextareaComponent } from '../../../shared/components/textarea/textarea.component';
import { PhotoUploaderComponent } from '../../../shared/components/photo-uploader/photo-uploader.component';
import { CropModalComponent } from '../crop-modal/crop-modal.component';
import { PetService } from '../../services/pet.service';
import type { CropModalOutputData, PhotoEntries, ThirdStepFormValue } from '../../pets.model';
import type { ExpandedPropertyValue } from '../../../app.model';

@Component({
  selector: 'pet-world-third-step-form',
  standalone: true,
  imports: [SelectComponent, TextareaComponent, PhotoUploaderComponent, NgClass, CdkDropList, CdkDrag, DragDropModule],
  templateUrl: './third-step-form.component.html',
  styleUrl: './third-step-form.component.scss',
})
export class ThirdStepFormComponent implements OnInit, AfterViewInit {
  readonly colorList = input.required<ExpandedPropertyValue[]>();
  readonly dropdownKey = input.required<string>();

  readonly isThirdStepFormValid = output<boolean>();

  private readonly petService: PetService = inject(PetService);
  private readonly fb = inject(FormBuilder);
  private readonly dialog: MatDialog = inject(MatDialog);
  private readonly destroy: DestroyRef = inject(DestroyRef);
  private readonly firstPhoto = signal('');
  private readonly secondPhoto = signal('');
  private readonly thirdPhoto = signal('');
  private readonly fourthPhoto = signal('');

  readonly placeholders = PLACEHOLDERS;
  readonly labelTypes = INPUT_LABELS;
  readonly summaryMaxLength = 300;
  readonly summaryHeight = '260px';
  readonly photoConfig = [this.firstPhoto, this.secondPhoto, this.thirdPhoto, this.fourthPhoto];

  private thirdStepForm!: FormGroup;

  get color(): FormControl {
    return this.thirdStepForm.get('color') as FormControl;
  }

  get summary(): FormControl {
    return this.thirdStepForm.get('summary') as FormControl;
  }

  get photos(): FormArray {
    return this.thirdStepForm.get('photos') as FormArray;
  }

  get summaryLength(): number {
    return this.summary.value?.length || 0;
  }

  ngOnInit() {
    this.thirdStepForm = this.initForm();
  }

  ngAfterViewInit(): void {
    setTimeout(() => {
      this.setFormValue();
      this.checkValueChanges();
    });
  }

  checkValueChanges(): void {
    this.thirdStepForm.valueChanges
      .pipe(
        tap(this.emitIsFormValid.bind(this)),
        switchMap(() => this.photos.valueChanges),
        tap(value => {
          Object.entries(value).forEach(photo => this.setPhoto(photo as unknown as PhotoEntries));
        }),
        takeUntilDestroyed(this.destroy),
      )
      .subscribe();
  }

  onAddPhoto(controlIndex: number): void {
    this.dialog
      .open(CropModalComponent, {
        data: { controlIndex },
      })
      .afterClosed()
      .pipe(
        filter(Boolean),
        tap(({ controlIndex, croppedImage }: CropModalOutputData) => {
          this.photos.at(controlIndex).setValue(croppedImage);
        }),
        takeUntilDestroyed(this.destroy),
      )
      .subscribe();
  }

  onRemovePhoto(controlIndex: number): void {
    const newPhotosValue = [...this.photos.value];
    newPhotosValue.splice(controlIndex, 1);
    newPhotosValue.push('');
    this.photos.setValue(newPhotosValue);
  }

  drop(event: CdkDragDrop<Signal<string>[]>) {
    moveItemInArray(this.photoConfig, event.previousIndex, event.currentIndex);
    const newPhotosValue = this.photoConfig.map(value => value());

    this.photos.setValue(newPhotosValue);
  }

  getFormValue(): ThirdStepFormValue {
    return this.thirdStepForm.value;
  }

  isFormValid(): boolean {
    return this.thirdStepForm.valid;
  }

  private emitIsFormValid(): void {
    this.isThirdStepFormValid.emit(this.isFormValid());
  }

  private initForm(): FormGroup {
    return this.fb.group({
      color: [null as unknown as ExpandedPropertyValue],
      summary: [''],
      photos: this.fb.array(['', '', '', '']),
    });
  }

  private setPhoto([index, croppedImage]: PhotoEntries): void {
    if (croppedImage) {
      this.photoConfig[index].set(croppedImage);
    }
  }

  private setFormValue(): void {
    const thirdFormValue = this.petService.getThirdFormValue();

    if (!thirdFormValue) return;

    this.thirdStepForm.setValue(thirdFormValue);
  }
}
