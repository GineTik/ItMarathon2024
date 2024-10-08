import { Injectable } from '@angular/core';

import { PERIOD_TYPES } from '../../app.config';
import type { Age, AgeControlValue } from '../pets.model';

@Injectable({
  providedIn: 'root',
})
export class AgeService {
  ageConfig = {
    [PERIOD_TYPES.DAYS]: 1,
    [PERIOD_TYPES.WEEKS]: 7,
    [PERIOD_TYPES.MONTHS]: 30,
    [PERIOD_TYPES.YEARS]: 365,
  };

  convertToNumber([value, unit]: AgeControlValue): Age {
    const ageUnit = this.ageConfig[unit as keyof typeof this.ageConfig];

    return {
      age: Number(value) * ageUnit,
      ageUnit,
    };
  }

  convertToString(ageUnit: number): PERIOD_TYPES {
    const [unit] = Object.entries(this.ageConfig).find(([_, coefficient]) => coefficient === ageUnit)!;

    return unit as PERIOD_TYPES;
  }

  getAgeForView(age: number, unit: number): string {
    const checkedUnit = Boolean(unit) ? unit : 1;
    const countedAge = age / checkedUnit;
    const unitString = this.convertToString(checkedUnit);

    return `${countedAge} ${unitString}`;
  }

  getAgeUnitCoefficient(unit: PERIOD_TYPES): number {
    return this.ageConfig[unit];
  }
}
