import { inject, Injectable } from '@angular/core';

import { DictionaryService } from './dictionary.service';
import { AgeService } from '../pets/services/age.service';
import type { AdRequestBody, EditProposalFormValue } from '../pets/pets.model';
import type {
  AdProperties,
  ChipsItem,
  ChipsItemRequest,
  PetRequestBody,
  PhotoItem,
  PropertiesRequestBody,
} from '../app.model';

@Injectable({
  providedIn: 'root',
})
export class GetPetRequestBodyService {
  private readonly ageService = inject(AgeService);
  private readonly dictionaryService = inject(DictionaryService);

  getRequestBody(formValue: AdRequestBody | EditProposalFormValue, isEdit = false): PetRequestBody {
    const properties = this.getProperties(formValue);
    const normalizedAgeUnit = this.ageService.getAgeUnitCoefficient(formValue.ageUnit);

    const requestBody = {
      isActive: true,
      title: formValue.title,
      price: formValue.price,
      location: formValue.location,
      petOrigin: formValue.petOrigin,
      age: formValue.age * normalizedAgeUnit,
      ageUnits: normalizedAgeUnit,
      summary: formValue.summary,
      properties,
    };

    return this.addPhotos(requestBody, formValue, isEdit);
  }

  private getProperties(formValue: AdRequestBody | EditProposalFormValue): PropertiesRequestBody {
    return [
      this.getAnimalType(formValue),
      this.getBreed(formValue),
      this.getSex(formValue),
      this.getColor(formValue),
      ...this.getHealth(formValue),
      ...this.getDocuments(formValue),
    ].filter(Boolean) as PropertiesRequestBody;
  }

  private getAnimalType(formValue: AdRequestBody | EditProposalFormValue): AdProperties {
    const { id, name } = this.dictionaryService.getPropertyInfo(this.dictionaryService.animalType);

    return {
      propertyDefinition: {
        id,
        name,
      },
      predefinedValue: formValue.animalType,
    };
  }

  private getBreed(formValue: AdRequestBody | EditProposalFormValue): AdProperties {
    const { id, name } = this.dictionaryService.getPropertyInfo(this.dictionaryService.breed);

    return {
      propertyDefinition: {
        id,
        name,
      },
      predefinedValue: formValue.breed,
    };
  }

  private getSex(formValue: AdRequestBody | EditProposalFormValue): AdProperties {
    const { id, name } = this.dictionaryService.getPropertyInfo(this.dictionaryService.sex);

    return {
      propertyDefinition: {
        id,
        name,
      },
      predefinedValue: formValue.sex,
    };
  }

  private getColor({ color }: AdRequestBody | EditProposalFormValue): AdProperties | null {
    if (!color?.value) return null;

    const { id, name } = this.dictionaryService.getPropertyInfo(this.dictionaryService.color);

    return {
      propertyDefinition: {
        id,
        name,
      },
      predefinedValue: color,
    };
  }

  private getHealth({ health }: AdRequestBody | EditProposalFormValue): ChipsItemRequest[] {
    return health?.length ? health.map(this.normalizeChips) : [];
  }

  private getDocuments({ documents }: AdRequestBody | EditProposalFormValue): ChipsItemRequest[] {
    return documents?.length ? documents.map(this.normalizeChips) : [];
  }

  private addPhotos(requestBody: any, { photos }: AdRequestBody | EditProposalFormValue, isEdit: boolean): any {
    let photoList;
    if (isEdit) {
      photoList = photos.filter(photo => Object.keys(photo).length > 0).map(photo => ({ ...(photo as PhotoItem) }));
    } else {
      photoList = photos.filter(Boolean).map(photo => ({ image: photo }));
    }

    if (!photoList.length) return requestBody;

    return {
      ...requestBody,
      photos: photoList,
    };
  }

  private normalizeChips({ id, name }: ChipsItem) {
    return {
      customValue: 'customValue',
      propertyDefinition: {
        id,
        name,
      },
    };
  }
}
