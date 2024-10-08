import { inject, Injectable, Signal } from '@angular/core';

import { DictionaryService } from '../../services/dictionary.service';
import { AgeService } from './age.service';
import { ADD_PET_PET_ORIGIN_OPTIONS_LIST } from '../../app.config';
import type { FullViewDetails, PhotoItem, ProposalItem, User, ViewDetails } from '../../app.model';
import { UserService } from '../../services/user.service';
import { PetService } from './pet.service';

@Injectable({
  providedIn: 'root',
})
export class PetViewService {
  private readonly ageService = inject(AgeService);
  private readonly dictionaryService = inject(DictionaryService);
  private readonly userService = inject(UserService);
  private readonly petService = inject(PetService);

  private readonly user: Signal<User | null> = this.userService.user;
  private readonly petOriginOptionList = ADD_PET_PET_ORIGIN_OPTIONS_LIST;
  private readonly genderId = 3;

  getFullViewDetails(formData: ProposalItem): FullViewDetails {
    const normalizedFormData = this.dictionaryService.getProposalFormData(formData);

    return {
      title: normalizedFormData.title,
      price: Number(normalizedFormData.price),
      userName: formData.appUser.name,
      phoneNumber: formData.appUser.phoneNumber || '',
      animalType: normalizedFormData.animalType.value,
      breed: normalizedFormData.breed.value,
      color: normalizedFormData.color?.value || '',
      age: this.ageService.getAgeForView(formData.age, formData.ageUnits),
      location: normalizedFormData.location,
      origin: this.petOriginOptionList.find(origin => origin.value === normalizedFormData.petOrigin)!.label,
      health: normalizedFormData.health,
      documents: normalizedFormData.documents,
      photos: normalizedFormData.photos,
      sex: formData.properties.find(({ propertyDefinition }: any) => propertyDefinition.id === this.genderId)!
        .predefinedValue.value,
      summary: normalizedFormData?.summary || '',
    };
  }

  getViewDetails(formData: ProposalItem): ViewDetails {
    return {
      title: formData.title,
      price: formData.price,
      age: this.ageService.getAgeForView(formData.age, formData.ageUnits),
      location: formData.location,
      photos: formData.photos?.[0]?.url || '',
      sex: formData.properties.find(({ propertyDefinition: { id } }) => id === this.genderId)!.predefinedValue.value,
      summary: formData.summary,
    };
  }

  getProposalPreview(): FullViewDetails {
    const formData = this.petService.getAdRequestBody();
    const photos = formData.photos.map(this.getPhotoItem);

    return {
      title: formData.title,
      price: Number(formData.price),
      userName: this.user()!.name,
      phoneNumber: this.user()?.phone_number || '',
      animalType: formData.animalType.value,
      breed: formData.breed.value,
      color: formData?.color?.value || '',
      age: `${formData.age} ${formData.ageUnit}`,
      location: formData.location,
      origin: this.petOriginOptionList.find(origin => origin.value === formData.petOrigin)!.label,
      health: formData.health,
      documents: formData.documents,
      photos: photos as PhotoItem[],
      sex: formData.sex.value,
      summary: formData?.summary || '',
    };
  }

  private getPhotoItem(blob: string): Partial<PhotoItem> {
    return { image: blob };
  }
}
