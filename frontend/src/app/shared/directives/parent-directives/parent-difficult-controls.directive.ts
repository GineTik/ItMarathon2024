import { AfterViewInit, DestroyRef, Directive, inject, input, OnInit } from '@angular/core';
import { FormControl, FormGroup, NonNullableFormBuilder, Validators } from '@angular/forms';

import { PetService } from '../../../pets/services/pet.service';
import { PERIOD_TYPES } from '../../../app.config';
import type { ChipsItem } from '../../../app.model';

@Directive({
  standalone: true,
})
export class ParentDifficultControlsDirective implements OnInit, AfterViewInit {
  readonly isAgeRequired = input<boolean>(true);

  protected readonly fb = inject(NonNullableFormBuilder);
  protected readonly destroyRef = inject(DestroyRef);

  private readonly petService: PetService = inject(PetService);

  get age() {
    return this.difficultForm?.get('age') as FormControl;
  }

  get ageUnit() {
    return this.difficultForm?.get('ageUnit') as FormControl;
  }

  get health() {
    return this.difficultForm?.get('health') as FormControl<ChipsItem[]>;
  }

  get documents() {
    return this.difficultForm?.get('documents') as FormControl<ChipsItem[]>;
  }

  difficultForm!: FormGroup;

  ngOnInit() {
    this.difficultForm = this.initForm();
    this.addAgeValidator();
  }

  ngAfterViewInit(): void {
    setTimeout(this.setFormValue.bind(this));
  }

  toggleChipsList(chips: ChipsItem, controlName: string): void {
    const chipsName = chips.name;
    const chipsList = this.difficultForm.get(controlName)?.value as ChipsItem[];
    const updatedChipsList = chipsList.some(({ name }) => chipsName === name)
      ? chipsList.filter(({ name }) => name !== chipsName)
      : [...chipsList, chips];
    this.difficultForm.get(controlName)?.setValue(updatedChipsList);
  }

  isFormValid(): boolean {
    return this.difficultForm.valid;
  }

  protected initForm(): FormGroup {
    return this.fb.group({
      age: ['', Validators.required],
      ageUnit: [null as unknown as PERIOD_TYPES, Validators.required],
      health: [[] as ChipsItem[]],
      documents: [[] as ChipsItem[]],
    });
  }

  protected setFormValue(): void {
    const secondFormValue = this.petService.getSecondFormValue();

    if (!secondFormValue) return;

    this.difficultForm.setValue(secondFormValue);
  }

  private addAgeValidator(): void {
    if (!this.isAgeRequired()) {
      this.ageUnit?.removeValidators(Validators.required);
      this.age?.removeValidators(Validators.required);
    }
  }
}
