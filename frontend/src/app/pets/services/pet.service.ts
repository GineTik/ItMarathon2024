import { Injectable } from '@angular/core';

import type { AdRequestBody, FirstStepFormValue, SecondStepFormValue, ThirdStepFormValue } from '../pets.model';

@Injectable({
  providedIn: 'root',
})
export class PetService {
  private firstFormValue!: FirstStepFormValue;
  private secondFormValue!: SecondStepFormValue;
  private thirdFormValue!: ThirdStepFormValue;

  saveFirstForm(value: unknown): void {
    this.firstFormValue = value as FirstStepFormValue;
  }

  saveSecondForm(value: unknown): void {
    this.secondFormValue = value as SecondStepFormValue;
  }

  saveThirdForm(value: unknown): void {
    this.thirdFormValue = value as ThirdStepFormValue;
  }

  getFirstFormValue(): FirstStepFormValue {
    return this.firstFormValue;
  }

  getSecondFormValue(): SecondStepFormValue {
    return this.secondFormValue;
  }

  getThirdFormValue(): ThirdStepFormValue {
    return this.thirdFormValue;
  }

  getAdRequestBody(): AdRequestBody {
    return {
      ...this.firstFormValue,
      ...this.secondFormValue,
      ...this.thirdFormValue,
    };
  }

  clearForm(): void {
    this.saveFirstForm(undefined);
    this.saveSecondForm(undefined);
    this.saveThirdForm(undefined);
  }
}
