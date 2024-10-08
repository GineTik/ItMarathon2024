import type { FormArray, FormControl } from '@angular/forms';

import { PERIOD_TYPES } from '../app.config';
import type { ChipsItem, ExpandedPropertyValue, FilterPetOrigin, PhotoItem, PropertyValue } from '../app.model';

// TODO: it will be used when ad will be send on BE
export interface FirstStepFormValue {
  title: string;
  animalType: PropertyValue;
  price: string;
  location: string;
  petOrigin: number;
}

export type FirstStepForm = {
  title: FormControl<string>;
  animalType: FormControl<PropertyValue>;
  price: FormControl<string>;
  location: FormControl<string>;
  petOrigin: FormControl<number>;
};

export interface StepConfigItem {
  stepNumber: number;
  title: string;
  progress: number;
}

export type StepConfig = [StepConfigItem, StepConfigItem, StepConfigItem];

export interface DifficultForm {
  age: FormControl<number>;
  health: FormControl<ChipsItem[]>;
  documents: FormControl<ChipsItem[]>;
  ageUnit: FormControl<PERIOD_TYPES>;
}

export interface SecondStepFormValue {
  breed: ExpandedPropertyValue;
  age: number;
  ageUnit: PERIOD_TYPES;
  sex: ExpandedPropertyValue;
  health: ChipsItem[];
  documents: ChipsItem[];
}

export interface ThirdStepFormValue {
  color: ExpandedPropertyValue;
  summary: string;
  photos: string[];
}

export type AdRequestBody = FirstStepFormValue & SecondStepFormValue & ThirdStepFormValue;

export interface SecondStepForm extends DifficultForm {
  breed: FormControl<ExpandedPropertyValue>;
  sex: FormControl<ExpandedPropertyValue>;
}

export interface CropModalData {
  controlIndex: number;
}

export interface CropModalOutputData extends CropModalData {
  croppedImage: string;
}

export type PhotoEntries = [number, string];

export interface FilterForm extends DifficultForm {
  animalType: FormControl<ExpandedPropertyValue>;
  breed: FormControl<ExpandedPropertyValue>;
  location: FormControl<string>;
  petOrigin: FormControl<FilterPetOrigin>;
  minPrice: FormControl<string>;
  maxPrice: FormControl<string>;
  sex: FormControl<string>;
  maxAge: FormControl<number>;
  maxAgeUnit: FormControl<PERIOD_TYPES>;
}

export type AgeControlValue = [number, PERIOD_TYPES];

export interface Age {
  age: number;
  ageUnit: number;
}

export interface PropertyValueList {
  animalType: PropertyValue;
  breed: ExpandedPropertyValue;
  sex: ExpandedPropertyValue;
  color: ExpandedPropertyValue;
}

export interface EditProposalFormValue extends PropertyValueList {
  title: string;
  price: string;
  location: string;
  age: number;
  ageUnit: PERIOD_TYPES;
  summary: string;
  photos: PhotoItem[];
  petOrigin: number;
  health: ChipsItem[];
  documents: ChipsItem[];
}

export interface EditProposalForm extends DifficultForm {
  title: FormControl<string>;
  price: FormControl<string>;
  location: FormControl<string>;
  animalType: FormControl<PropertyValue>;
  breed: FormControl<ExpandedPropertyValue>;
  sex: FormControl<ExpandedPropertyValue>;
  color: FormControl<ExpandedPropertyValue>;
  summary: FormControl<string>;
  photos: FormArray<FormControl<PhotoItem>>;
  petOrigin: FormControl<number>;
}

export interface AgeControlsValueChangesData {
  value: string | number;
  controlName: AgeControlsNames;
}

export type AgeControlsNames = 'ageUnit' | 'maxAgeUnit' | 'age' | 'maxAge';
