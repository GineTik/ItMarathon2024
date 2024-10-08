import { AfterViewInit, Component, DestroyRef, inject, input, output } from '@angular/core';
import { FormArray, FormControl, Validators } from '@angular/forms';
import { takeUntilDestroyed } from '@angular/core/rxjs-interop';
import { CdkDragDrop, moveItemInArray } from '@angular/cdk/drag-drop';
import { MatDialog } from '@angular/material/dialog';
import { filter, tap } from 'rxjs';

import {
  ADD_PET_PET_ORIGIN_OPTIONS_LIST,
  INPUT_LABELS,
  INPUT_TYPES,
  PERIOD_TYPE_LIST,
  PLACEHOLDERS,
} from '../../../app.config';
import CITY_LIST from '../../../../city-db';
import { GalleryComponent } from '../gallery/gallery.component';
import { CropModalComponent } from '../crop-modal/crop-modal.component';
import { ParentDifficultControlsDirective } from '../../../shared/directives/parent-directives/parent-difficult-controls.directive';
import { ChipsComponent } from '../../../shared/components/chips/chips.component';
import { TextareaComponent } from '../../../shared/components/textarea/textarea.component';
import { InputComponent } from '../../../shared/components/input/input.component';
import { CheckboxComponent } from '../../../shared/components/checkbox/checkbox.component';
import { SelectComponent } from '../../../shared/components/select/select.component';
import { IsChipsActivePipe } from '../../../shared/pipes/is-chips-active.pipe';
import { RadioButtonComponent } from '../../../shared/components/radio-button/radio-button.component';
import { DictionaryService } from '../../../services/dictionary.service';
import type { ChipsItem, ExpandedPropertyValue, PhotoItem, PropertyValue, ProposalItem } from '../../../app.model';
import type { CropModalOutputData, EditProposalFormValue } from '../../pets.model';

@Component({
  selector: 'pet-world-edit-ad-form',
  standalone: true,
  imports: [
    ParentDifficultControlsDirective,
    GalleryComponent,
    ChipsComponent,
    TextareaComponent,
    InputComponent,
    CheckboxComponent,
    SelectComponent,
    IsChipsActivePipe,
    RadioButtonComponent,
  ],
  templateUrl: './edit-ad-form.component.html',
  styleUrl: './edit-ad-form.component.scss',
  hostDirectives: [
    {
      directive: ParentDifficultControlsDirective,
      inputs: ['isAgeRequired'],
    },
  ],
})
export class EditAdFormComponent extends ParentDifficultControlsDirective implements AfterViewInit {
  readonly proposal = input.required<ProposalItem>();
  readonly isUserOwned = input<boolean>(false);

  animalTypes = input.required<ExpandedPropertyValue[]>();
  genderList = input.required<ExpandedPropertyValue[]>();
  colorList = input.required<ExpandedPropertyValue[]>();
  healthList = input.required<ChipsItem[]>();
  documentList = input.required<ChipsItem[]>();

  private readonly destroy: DestroyRef = inject(DestroyRef);
  private readonly dialog: MatDialog = inject(MatDialog);
  private readonly dictionaryService = inject(DictionaryService);

  breeds!: ExpandedPropertyValue[];

  readonly cityList = CITY_LIST;
  readonly labelTypes = INPUT_LABELS;
  readonly inputTypes = INPUT_TYPES;
  readonly placeholders = PLACEHOLDERS;
  readonly periodTypes = PERIOD_TYPE_LIST;
  readonly freeSaleCheckbox = new FormControl(false);
  readonly isEditProposalFormValid = output<boolean>();
  readonly dropdownKey: string = 'value';
  readonly summaryMaxLength = 300;
  readonly summaryHeight = '138px';
  readonly petOriginOptionList = ADD_PET_PET_ORIGIN_OPTIONS_LIST;

  get title(): FormControl {
    return this.difficultForm.get('title') as FormControl;
  }

  get animalType(): FormControl {
    return this.difficultForm.get('animalType') as FormControl;
  }

  get price(): FormControl {
    return this.difficultForm.get('price') as FormControl;
  }

  get breed(): FormControl {
    return this.difficultForm.get('breed') as FormControl;
  }

  get sex(): FormControl {
    return this.difficultForm.get('sex') as FormControl;
  }

  get location(): FormControl {
    return this.difficultForm.get('location') as FormControl;
  }

  get petOrigin(): FormControl {
    return this.difficultForm.get('petOrigin') as FormControl;
  }

  get titleLength(): number {
    return this.title.value?.length || 0;
  }

  get photos(): FormArray {
    return this.difficultForm.get('photos') as FormArray;
  }

  get color(): FormControl {
    return this.difficultForm.get('color') as FormControl;
  }

  get summary(): FormControl {
    return this.difficultForm.get('summary') as FormControl;
  }

  get summaryLength(): number {
    return this.summary.value?.length || 0;
  }

  override ngOnInit(): void {
    super.ngOnInit();
    this.difficultForm = this.initForm();
    this.onFreeSaleChange();
    this.onPriceCheck();
    this.onAnimalTypeChange();
  }

  override ngAfterViewInit(): void {
    setTimeout(() => {
      this.setFormValue();
      this.emitIsFormValid();
      this.checkValueChanges();
    });
  }

  onEditPhoto(controlIndex: number): void {
    this.dialog
      .open(CropModalComponent, {
        data: { controlIndex },
      })
      .afterClosed()
      .pipe(
        filter(Boolean),
        tap(({ controlIndex, croppedImage }: CropModalOutputData) => {
          this.photos.at(controlIndex).setValue({ image: croppedImage });
        }),
        takeUntilDestroyed(this.destroy),
      )
      .subscribe();
  }

  onRemovePhoto(controlIndex: number): void {
    const newPhotosValue = [...this.photos.value];
    newPhotosValue.splice(controlIndex, 1);
    newPhotosValue.push({});
    this.photos.setValue(newPhotosValue);
  }

  onDrag(event: CdkDragDrop<PhotoItem[]>) {
    const newPhotosValue = [...this.photos.value];
    moveItemInArray(newPhotosValue, event.previousIndex, event.currentIndex);
    this.photos.setValue(newPhotosValue);
  }

  checkValueChanges(): void {
    this.difficultForm.valueChanges
      .pipe(
        tap(() => this.difficultForm.markAsDirty()),
        tap(this.emitIsFormValid.bind(this)),
        takeUntilDestroyed(this.destroy),
      )
      .subscribe();
  }

  getFormValue(): EditProposalFormValue {
    return this.difficultForm.value as EditProposalFormValue;
  }

  protected override initForm() {
    return this.fb.group({
      ...super.initForm().controls,
      title: ['', Validators.required],
      price: ['', Validators.required],
      animalType: [null as unknown as PropertyValue, Validators.required],
      color: [null as unknown as ExpandedPropertyValue],
      location: [null as unknown as string, Validators.required],
      petOrigin: [1, Validators.required],
      summary: [''],
      breed: [null as unknown as ExpandedPropertyValue, Validators.required],
      sex: [this.genderList()[0], Validators.required],
      photos: this.fb.array([{}, {}, {}, {}]),
    });
  }

  protected override setFormValue(): void {
    const normalizedFormData = this.dictionaryService.getProposalFormData(this.proposal());

    this.difficultForm.patchValue(normalizedFormData);
  }

  private emitIsFormValid(): void {
    this.isEditProposalFormValid.emit(this.isFormValid() && this.difficultForm.dirty);
  }

  private onFreeSaleChange(): void {
    this.freeSaleCheckbox.valueChanges
      .pipe(
        tap(value => {
          value ? this.price.setValue(0, { emitEvent: false }) : this.price.reset({ emitEvent: false });
        }),
        tap(() => this.difficultForm.markAsDirty()),
        takeUntilDestroyed(this.destroy),
      )
      .subscribe();
  }

  private onPriceCheck(): void {
    this.price.valueChanges
      .pipe(
        tap(value => {
          if (value || value === '') {
            this.freeSaleCheckbox.setValue(false, { emitEvent: false });
          }
          if (value.length >= 1 && String(value).startsWith('0')) {
            const firstNaturalNumberIndex = value.split('').findIndex((char: number) => char > 0);
            this.price.setValue(value.slice(firstNaturalNumberIndex), { emitEvent: false });
          }

          if (value === '0' || value === 0) {
            this.freeSaleCheckbox.setValue(true);
          }
        }),
        takeUntilDestroyed(this.destroy),
      )
      .subscribe();
  }

  private onAnimalTypeChange(): void {
    this.animalType.valueChanges
      .pipe(
        tap(() => {
          this.breed.reset();
        }),
        filter(Boolean),
        tap(value => {
          this.breeds = this.dictionaryService.getBreeds(value);
        }),
        takeUntilDestroyed(this.destroy),
      )
      .subscribe();
  }
}
