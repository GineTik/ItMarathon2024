import { inject, Injectable } from '@angular/core';

import type {
  ChipsCategory,
  ChipsItem,
  Dictionary,
  DictionaryConfig,
  ExpandedPropertyValue,
  NormalizedDictionary,
  ParentDictionaryItem,
  PropertyValue,
  ProposalItem,
  ProposalPropertyItem,
} from '../app.model';
import { ApiService } from './api.service';
import { AgeService } from '../pets/services/age.service';
import { firstValueFrom, of, take, tap } from 'rxjs';
import { EditProposalFormValue, PropertyValueList } from '../pets/pets.model';
import { PERIOD_TYPES } from '../app.config';
import DICTIONARY_MOCK from '../dictionary.mock';

@Injectable({
  providedIn: 'root',
})
export class DictionaryService {
  private readonly apiService: ApiService = inject(ApiService);
  private readonly ageService: AgeService = inject(AgeService);

  readonly animalType = 'animalType';
  readonly breed = 'breed';
  readonly sex = 'sex';
  readonly color = 'color';
  readonly health = 'Health';
  readonly documents = 'Documents';

  private dictionary!: NormalizedDictionary;

  normalizeDictionary(dictionary: Dictionary): void {
    const dictionaryConfig = this.getDictionaryConfig();

    this.dictionary = dictionary.reduce((acc, item) => {
      const currentFieldIndex = item.id;

      if (dictionaryConfig[currentFieldIndex]) {
        const key = dictionaryConfig[currentFieldIndex];
        acc[key] = item;
      }

      if ((item as ChipsItem)?.category) {
        const key = (item as ChipsItem).category;
        const chipsList = this.getChipsList(acc, key, item as ChipsItem);

        acc = { ...acc, [key]: chipsList };
      }

      return acc;
    }, {} as NormalizedDictionary);
  }

  getAnimalTypes(): ExpandedPropertyValue[] {
    return (this.dictionary[this.animalType] as ParentDictionaryItem).propertyValues;
  }

  getBreeds(animalType: PropertyValue): ExpandedPropertyValue[] {
    return (this.dictionary[this.breed] as ParentDictionaryItem).propertyValues.filter(item =>
      !item.parentPropertyValue ? false : item.parentPropertyValue.value === animalType.value,
    );
  }

  getGenderList(): ExpandedPropertyValue[] {
    return (this.dictionary[this.sex] as ParentDictionaryItem).propertyValues;
  }

  getColorList(): ExpandedPropertyValue[] {
    return (this.dictionary[this.color] as ParentDictionaryItem).propertyValues;
  }

  getHealthList(): ChipsItem[] {
    return this.dictionary[this.health] as ChipsItem[];
  }

  getDocumentsList(): ChipsItem[] {
    return this.dictionary[this.documents] as ChipsItem[];
  }

  getPropertyInfo(key: keyof NormalizedDictionary): ParentDictionaryItem {
    return this.dictionary[key] as ParentDictionaryItem;
  }

  loadDictionary(): Promise<Dictionary> {
    return firstValueFrom(
      this.apiService.getDictionary().pipe(
        tap(data => this.normalizeDictionary(data)),
        take(1),
      ),
    );
  }

  loadMockDictionary(): Promise<Dictionary> {
    return firstValueFrom(
      of(DICTIONARY_MOCK).pipe(
        tap(data => this.normalizeDictionary(data)),
        take(1),
      ),
    );
  }

  getProposalChipsList = (propertyList: ProposalPropertyItem[], key: ChipsCategory): ChipsItem[] => {
    const isChips = (property: ProposalPropertyItem): boolean => {
      return !!property.customValue && (property.propertyDefinition as ChipsItem).category === key;
    };

    return propertyList.filter(property => isChips(property)).map(property => property.propertyDefinition as ChipsItem);
  };

  getProposalFormData = (proposal: ProposalItem): EditProposalFormValue => {
    const dictionaryConfig = this.getDictionaryConfig();
    const { age, location, price, summary, title, petOrigin, photos, properties, ageUnits } = proposal;
    const proposalFormData = {
      age: age / ageUnits,
      location,
      price: price.toString(),
      summary,
      title,
      petOrigin,
      photos,
      ageUnit: this.ageService.convertToString(ageUnits || 1),
    };
    const health = this.getProposalChipsList(properties, 'Health');
    const documents = this.getProposalChipsList(properties, 'Documents');

    const normalizePropertyArr = properties.reduce((acc, item) => {
      const currentFieldIndex = item.propertyDefinition.id;

      if (dictionaryConfig[currentFieldIndex]) {
        const key = dictionaryConfig[currentFieldIndex] as keyof PropertyValueList;
        if (key) {
          acc[key] = item.predefinedValue ?? ({} as PropertyValue & ExpandedPropertyValue);
        }
      }
      return acc;
    }, {} as PropertyValueList);

    return { ...proposalFormData, health, documents, ...normalizePropertyArr };
  };

  private getDictionaryConfig(): DictionaryConfig {
    return {
      1: this.animalType,
      2: this.breed,
      3: this.sex,
      5: this.color,
    };
  }

  private getChipsList(acc: NormalizedDictionary, key: keyof NormalizedDictionary, item: ChipsItem): ChipsItem[] {
    const chipsList = acc[key] as ChipsItem[];

    if (chipsList) {
      return [...chipsList, item];
    } else {
      return [item];
    }
  }
}
