import { Component, inject, input, OnInit, output, signal } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { takeUntilDestroyed } from '@angular/core/rxjs-interop';
import { filter, map, merge, Observable, tap } from 'rxjs';

import { SelectComponent } from '../../../shared/components/select/select.component';
import { ParentDifficultControlsDirective } from '../../../shared/directives/parent-directives/parent-difficult-controls.directive';
import {
  AD_FORM_CONTROL_NAME,
  GENDER_LIST,
  INPUT_LABELS,
  INPUT_TYPES,
  PERIOD_TYPE_LIST,
  PLACEHOLDERS,
  PERIOD_TYPES,
  ADD_PET_PET_ORIGIN_OPTIONS_LIST,
} from '../../../app.config';
import CITY_LIST from '../../../../city-db';
import { InputComponent } from '../../../shared/components/input/input.component';
import { CheckboxComponent } from '../../../shared/components/checkbox/checkbox.component';
import { RadioButtonComponent } from '../../../shared/components/radio-button/radio-button.component';
import { ChipsComponent } from '../../../shared/components/chips/chips.component';
import { ButtonComponent } from '../../../shared/components/button/button.component';
import { IsChipsActivePipe } from '../../../shared/pipes/is-chips-active.pipe';
import { FilterService } from '../../../services/filter.service';
import type { AgeControlsValueChangesData, DifficultForm, FilterForm } from '../../pets.model';
import type { ChipsItem, ExpandedPropertyValue, FilterFormValue, FilterPetOrigin } from '../../../app.model';

@Component({
  selector: 'pet-world-filter-form',
  standalone: true,
  imports: [
    SelectComponent,
    InputComponent,
    CheckboxComponent,
    RadioButtonComponent,
    ChipsComponent,
    ButtonComponent,
    IsChipsActivePipe,
  ],
  templateUrl: './filter-form.component.html',
  styleUrl: './filter-form.component.scss',
})
export class FilterFormComponent extends ParentDifficultControlsDirective implements OnInit {
  readonly petTypes = input.required<ExpandedPropertyValue[]>();
  readonly breedList = input.required<ExpandedPropertyValue[]>();
  readonly healthList = input.required<ChipsItem[]>();
  readonly documentList = input.required<ChipsItem[]>();
  readonly isFilterFormInValid = signal(false);

  readonly getBreedList = output<ExpandedPropertyValue>();
  readonly filterFormValue = output<FilterFormValue>();

  private readonly filterService = inject(FilterService);

  readonly petOriginOptionList = ADD_PET_PET_ORIGIN_OPTIONS_LIST;
  readonly periodTypes = PERIOD_TYPE_LIST;
  readonly genderList = GENDER_LIST;
  readonly cityList = CITY_LIST;
  readonly formControlName = AD_FORM_CONTROL_NAME;
  readonly placeholders = PLACEHOLDERS;
  readonly labelTypes = INPUT_LABELS;
  readonly inputTypes = INPUT_TYPES;
  readonly freeSaleCheckbox = new FormControl(false);

  get animalType(): FormControl {
    return this.difficultForm.get('animalType') as FormControl;
  }

  get breed(): FormControl {
    return this.difficultForm.get('breed') as FormControl;
  }

  get location(): FormControl {
    return this.difficultForm.get('location') as FormControl;
  }

  get petOrigin(): FormControl {
    return this.difficultForm.get('petOrigin') as FormControl;
  }

  get minPrice(): FormControl {
    return this.difficultForm.get('minPrice') as FormControl;
  }

  get maxPrice(): FormControl {
    return this.difficultForm.get('maxPrice') as FormControl;
  }

  get sex(): FormControl {
    return this.difficultForm.get('sex') as FormControl;
  }

  get maxAge(): FormControl {
    return this.difficultForm.get('maxAge') as FormControl;
  }

  get maxAgeUnit(): FormControl {
    return this.difficultForm.get('maxAgeUnit') as FormControl;
  }

  override ngOnInit() {
    super.ngOnInit();

    this.onAnimalTypeChange();
    this.checkAgeCategoryControls();
    this.onFreeSaleChange();
    this.onPriceCheck('minPrice');
    this.onPriceCheck('maxPrice');
    this.difficultForm.patchValue(this.filterService.getFilterState(), { emitEvent: false });
  }

  filterPetLisT() {
    this.filterFormValue.emit(this.difficultForm.value);
  }

  clearForm() {
    this.difficultForm.reset();
  }

  protected override initForm(): FormGroup<FilterForm> {
    return this.fb.group({
      ...(super.initForm().controls as unknown as DifficultForm),
      animalType: [null as unknown as ExpandedPropertyValue],
      breed: [null as unknown as ExpandedPropertyValue],
      location: [null as unknown as string],
      petOrigin: [null as unknown as FilterPetOrigin],
      minPrice: ['' as unknown as string],
      maxPrice: ['' as unknown as string],
      sex: [null as unknown as string],
      maxAgeUnit: [null as unknown as PERIOD_TYPES],
      maxAge: [null as unknown as number],
    });
  }

  private onFreeSaleChange(): void {
    this.freeSaleCheckbox.valueChanges
      .pipe(
        tap(value => {
          this.changePriceValue(value, 'minPrice');
          this.changePriceValue(value, 'maxPrice');
          this.isFilterFormInValid.set(this.maxPrice.invalid);
        }),
        takeUntilDestroyed(this.destroyRef),
      )
      .subscribe();
  }

  private changePriceValue(value: boolean | null, fieldName: 'minPrice' | 'maxPrice'): void {
    value ? this[fieldName].setValue(0, { emitEvent: false }) : this[fieldName].reset({ emitEvent: false });
  }

  private onPriceCheck(fieldName: 'minPrice' | 'maxPrice'): void {
    this[fieldName].valueChanges
      .pipe(
        tap(value => {
          if (value || value === '') {
            this.freeSaleCheckbox.setValue(false, { emitEvent: false });
          }

          if (value >= 1 && value.startsWith(0)) {
            const firstNaturalNumberIndex = value.split('').findIndex((char: number) => char > 0);
            this[fieldName].setValue(value.slice(firstNaturalNumberIndex), { emitEvent: false });
          }

          if (value === '0' || value === 0) {
            this.freeSaleCheckbox.setValue(true, { emitEvent: false });
          }
        }),
        tap(() => {
          if (this.maxPrice.value && Number(this.minPrice.value) >= Number(this.maxPrice.value)) {
            this.maxPrice.setErrors({ maxPrice: true });
          } else {
            this.maxPrice.setErrors(null);
          }
        }),
        tap(() => {
          this.isFilterFormInValid.set(this.difficultForm.invalid);
        }),
        takeUntilDestroyed(this.destroyRef),
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
        tap(value => this.getBreedList.emit(value)),
        takeUntilDestroyed(this.destroyRef),
      )
      .subscribe();
  }

  private checkAgeCategoryControls(): void {
    merge(this.onAgeUnitChange(), this.onMinAgeChange(), this.onMaxAgeChange(), this.onMaxAgeUnitChange())
      .pipe(
        tap(this.handleAgeValidation.bind(this)),
        tap(() => {
          this.isFilterFormInValid.set(this.difficultForm.invalid);
        }),
        takeUntilDestroyed(this.destroyRef),
      )
      .subscribe();
  }

  private handleAgeValidation({ value, controlName }: AgeControlsValueChangesData): void {
    if (!!value) {
      this[controlName].setValidators([Validators.required]);
      this[controlName].markAsTouched();
      this[controlName].markAsDirty();
    } else {
      this[controlName].clearValidators();
    }
    this[controlName].updateValueAndValidity({ emitEvent: false });
  }

  private onMinAgeChange(): Observable<AgeControlsValueChangesData> {
    return this.age.valueChanges.pipe(
      map(value => ({
        value,
        controlName: 'ageUnit',
      })),
    );
  }

  private onMaxAgeChange(): Observable<AgeControlsValueChangesData> {
    return this.maxAge.valueChanges.pipe(
      map(value => ({
        value,
        controlName: 'maxAgeUnit',
      })),
    );
  }

  private onAgeUnitChange(): Observable<AgeControlsValueChangesData> {
    return this.ageUnit.valueChanges.pipe(
      map(value => ({
        value,
        controlName: 'age',
      })),
    );
  }

  private onMaxAgeUnitChange(): Observable<AgeControlsValueChangesData> {
    return this.maxAgeUnit.valueChanges.pipe(
      map(value => ({
        value,
        controlName: 'maxAge',
      })),
    );
  }
}
