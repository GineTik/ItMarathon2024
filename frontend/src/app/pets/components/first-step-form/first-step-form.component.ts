import { AfterViewInit, Component, DestroyRef, inject, input, OnInit, output } from '@angular/core';
import { FormControl, FormGroup, NonNullableFormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { takeUntilDestroyed } from '@angular/core/rxjs-interop';
import { MatRadioButton, MatRadioGroup } from '@angular/material/radio';
import { tap } from 'rxjs';

import { CheckboxComponent } from '../../../shared/components/checkbox/checkbox.component';
import { InputComponent } from '../../../shared/components/input/input.component';
import { SelectComponent } from '../../../shared/components/select/select.component';
import { TextareaComponent } from '../../../shared/components/textarea/textarea.component';
import { RadioButtonComponent } from '../../../shared/components/radio-button/radio-button.component';
import CITY_LIST from '../../../../city-db';
import { ADD_PET_PET_ORIGIN_OPTIONS_LIST, INPUT_LABELS, INPUT_TYPES, PLACEHOLDERS } from '../../../app.config';
import { PetService } from '../../services/pet.service';
import type { FirstStepForm } from '../../pets.model';
import type { ExpandedPropertyValue, PropertyValue } from '../../../app.model';

@Component({
  selector: 'pet-world-first-step-form',
  standalone: true,
  imports: [
    CheckboxComponent,
    InputComponent,
    MatRadioButton,
    MatRadioGroup,
    SelectComponent,
    TextareaComponent,
    ReactiveFormsModule,
    ReactiveFormsModule,
    RadioButtonComponent,
  ],
  templateUrl: './first-step-form.component.html',
  styleUrl: './first-step-form.component.scss',
})
export class FirstStepFormComponent implements OnInit, AfterViewInit {
  private readonly fb: NonNullableFormBuilder = inject(NonNullableFormBuilder);
  private readonly destroy: DestroyRef = inject(DestroyRef);
  private readonly petService: PetService = inject(PetService);

  private firstStepForm!: FormGroup<FirstStepForm>;

  readonly cityList = CITY_LIST;
  readonly labelTypes = INPUT_LABELS;
  readonly inputTypes = INPUT_TYPES;
  readonly placeholders = PLACEHOLDERS;
  readonly petOriginOptionList = ADD_PET_PET_ORIGIN_OPTIONS_LIST;
  readonly freeSaleCheckbox = new FormControl(false);
  readonly animalTypes = input.required<ExpandedPropertyValue[]>();
  readonly dropdownKey = input.required<string>();
  readonly isFirstStepFormValid = output<boolean>();
  readonly chosenPetType = output<PropertyValue>();

  get title(): FormControl {
    return this.firstStepForm.get('title') as FormControl;
  }

  get animalType(): FormControl {
    return this.firstStepForm.get('animalType') as FormControl;
  }

  get price(): FormControl {
    return this.firstStepForm.get('price') as FormControl;
  }

  get location(): FormControl {
    return this.firstStepForm.get('location') as FormControl;
  }

  get petOrigin(): FormControl {
    return this.firstStepForm.get('petOrigin') as FormControl;
  }

  get titleLength(): number {
    return this.title.value?.length || 0;
  }

  ngOnInit() {
    this.firstStepForm = this.initForm();
    this.onFreeSaleChange();
    this.onPriceCheck();
    this.onAnimalTypeChange();
    this.emitIsFormValid();
  }

  ngAfterViewInit(): void {
    setTimeout(() => {
      this.setFormValue();
      this.checkValueChanges();
    });
  }

  checkValueChanges(): void {
    this.firstStepForm.valueChanges
      .pipe(tap(this.emitIsFormValid.bind(this)), takeUntilDestroyed(this.destroy))
      .subscribe();
  }

  getFormValue(): FirstStepForm {
    return this.firstStepForm.value as unknown as FirstStepForm;
  }

  private initForm() {
    return this.fb.group({
      title: ['', Validators.required],
      animalType: [null as unknown as PropertyValue, Validators.required],
      price: ['', Validators.required],
      location: [null as unknown as string, Validators.required],
      petOrigin: [1, Validators.required],
    });
  }

  private emitIsFormValid(): void {
    this.isFirstStepFormValid.emit(this.firstStepForm.valid);
  }

  private onFreeSaleChange(): void {
    this.freeSaleCheckbox.valueChanges
      .pipe(
        tap(value => {
          value ? this.price.setValue(0, { emitEvent: false }) : this.price.reset({ emitEvent: false });
        }),
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

          if (value >= 1 && value.startsWith(0)) {
            const firstNaturalNumberIndex = value.split('').findIndex((char: number) => char > 0);
            this.price.setValue(value.slice(firstNaturalNumberIndex), { emitEvent: false });
          }

          if (value === '0' || value === 0) {
            this.freeSaleCheckbox.setValue(true, { emitEvent: false });
          }
        }),
        takeUntilDestroyed(this.destroy),
      )
      .subscribe();
  }

  private onAnimalTypeChange(): void {
    this.animalType.valueChanges
      .pipe(
        tap(value => {
          this.chosenPetType.emit(value);
        }),
        takeUntilDestroyed(this.destroy),
      )
      .subscribe();
  }

  private setFormValue(): void {
    const firstFormValue = this.petService.getFirstFormValue();

    if (!firstFormValue) return;

    this.firstStepForm.setValue(firstFormValue);
  }
}
