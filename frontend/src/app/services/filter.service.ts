import { inject, Injectable } from '@angular/core';

import { SEARCH_NAMES, SORT_OPTIONS } from '../app.config';
import { AgeService } from '../pets/services/age.service';
import type { FilterFormValue } from '../app.model';

@Injectable({
  providedIn: 'root',
})
export class FilterService {
  private readonly ageService = inject(AgeService);

  private sortingValue = '&$orderby=CreatedOn desc';
  private filterValue: string = '$filter=IsActive eq true';
  private filterState!: Partial<FilterFormValue>;
  private sortingState: SORT_OPTIONS = SORT_OPTIONS.newest;

  setQueryFilter(formValue: Partial<FilterFormValue> | null): void {
    const query = formValue && Object.values(formValue).some(Boolean) ? `${this.getFilterValue(formValue)}` : '';
    this.saveFilterState(formValue);

    this.filterValue = `$filter=IsActive eq true${query}`;
  }

  getFilterQuery(): string {
    return `?${this.filterValue}${this.sortingValue}`;
  }

  mainPageFilter(): string {
    return '?$filter=IsActive eq true&$orderby=CreatedOn desc&$top=4';
  }

  profilePageFilter(userId: number, top: number): string {
    return `?$filter=appUser/id eq ${userId}&$top=${top}&$orderby=CreatedOn desc`;
  }

  setSorting(sorting: SORT_OPTIONS): void {
    const sortingConfig = {
      [SORT_OPTIONS.newest]: 'CreatedOn desc',
      [SORT_OPTIONS.fromCheap]: 'Price asc',
      [SORT_OPTIONS.fromExpensive]: 'Price desc',
    };
    this.saveSortingState(sorting);
    this.sortingValue = `&$orderby=${sortingConfig[sorting]}`;
  }

  getFilterState(): Partial<FilterFormValue> {
    return this.filterState;
  }

  getSortingState(): SORT_OPTIONS {
    return this.sortingState;
  }

  private saveFilterState(formValue: Partial<FilterFormValue> | null): void {
    if (!formValue) return;

    this.filterState = formValue;
  }

  private saveSortingState(sortingValue: SORT_OPTIONS): void {
    this.sortingState = sortingValue;
  }

  private getFilterValue(formValue: Partial<FilterFormValue>): string {
    const filterList = [
      this.getLocation(formValue),
      this.getAnimalType(formValue),
      this.getBreed(formValue),
      this.getPrice(formValue),
      this.getAge(formValue),
      this.getPetOwner(formValue),
      this.getGender(formValue),
      this.getChips(formValue),
    ].filter(Boolean);

    return filterList.length ? ` and ${filterList.join(' and ')}` : '';
  }

  private getLocation({ location }: Partial<FilterFormValue>): string {
    return location ? `Location eq '${location}'` : '';
  }

  private getAnimalType({ animalType }: Partial<FilterFormValue>): string {
    return animalType
      ? `Properties/any(p:p/PropertyDefinition/Name eq '${SEARCH_NAMES.animalType}' and p/PredefinedValue/Value eq '${animalType.value}')`
      : '';
  }

  private getBreed({ breed }: Partial<FilterFormValue>): string {
    return breed
      ? `Properties/any(p:p/PropertyDefinition/Name eq '${SEARCH_NAMES.breed}' and p/PredefinedValue/Value eq '${breed.value}')`
      : '';
  }

  private getPrice({ minPrice, maxPrice }: Partial<FilterFormValue>): string {
    if ((maxPrice || maxPrice === 0) && (minPrice || minPrice === 0)) {
      return `Price ge ${minPrice} and Price le ${maxPrice}`;
    } else if (maxPrice && !minPrice) {
      return `Price le ${maxPrice}`;
    } else if (!maxPrice && (minPrice || minPrice === 0)) {
      return `Price ge ${minPrice}`;
    } else {
      return '';
    }
  }

  private getAge({ age, ageUnit, maxAge, maxAgeUnit }: Partial<FilterFormValue>): string {
    if (!age && !maxAge) return '';
    const minAgeUnitCoefficient = this.ageService.getAgeUnitCoefficient(ageUnit!);
    const maxAgeUnitCoefficient = this.ageService.getAgeUnitCoefficient(maxAgeUnit!);
    const calculatedMinAge = age! * minAgeUnitCoefficient;
    const calculatedMaxAge = maxAge! * maxAgeUnitCoefficient;

    if (age && maxAge) {
      return `age ge ${calculatedMinAge} and age le ${calculatedMaxAge}`;
    } else if (maxAge && !age) {
      return `age le ${calculatedMaxAge}`;
    } else {
      return `age ge ${calculatedMinAge}`;
    }
  }

  private getPetOwner({ petOrigin }: Partial<FilterFormValue>): string {
    return petOrigin ? `PetOrigin eq ItMarathon.Dal.Enums.PetOrigin'${petOrigin.value}'` : '';
  }

  private getGender({ sex, petOrigin }: Partial<FilterFormValue>): string {
    // Special case for custom bug by testing team request
    if (petOrigin?.value === 2) sex = 'Хлопчик';

    return sex
      ? `Properties/any(p:p/PropertyDefinition/Name eq '${SEARCH_NAMES.sex}' and p/PredefinedValue/Value eq '${sex}')`
      : '';
  }

  private getChips({ health, documents }: Partial<FilterFormValue>): string {
    const chipsList = [...(health || []), ...(documents || [])];
    const queryList = chipsList?.map(({ id }) => `Properties/any(p:p/PropertyDefinition/Id eq ${id})`) || [];

    return queryList?.length ? queryList.join(' and ') : '';
  }
}
