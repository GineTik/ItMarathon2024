import type { FormControl } from '@angular/forms';

import { PERIOD_TYPES } from './app.config';

type PetOrigin = 1 | 2 | 3;

export type Dictionary = (ParentDictionaryItem | ChipsItem)[];

export interface ParentDictionaryItem {
  id: number;
  name: string;
  propertyDefinitionType: number;
  isMandatory: boolean;
  propertyValues: ExpandedPropertyValue[];
}

export type ChipsCategory = 'Health' | 'Documents';

export interface ChipsItem extends ParentDictionaryItem {
  category: ChipsCategory;
}

export interface PropertyValue {
  id: number;
  value: string;
}

export interface ExpandedPropertyValue extends PropertyValue {
  parentPropertyValue?: PropertyValue;
}

export interface NormalizedDictionary {
  [key: string]: ParentDictionaryItem | ChipsItem[];
}

export interface DictionaryConfig {
  [key: number]: string;
}

export interface PhotoItem {
  id: number;
  url: string;
  image?: string;
}

export interface User {
  created_on: string;
  email: string;
  id: number;
  is_active: boolean;
  is_superuser: boolean;
  is_verified: boolean;
  last_modified_on: string;
  location: string;
  name: string;
  phone_number: string;
  prefers_phone_call: boolean;
  prefers_telegram: boolean;
  surname: string;
}

export interface ProposalUser {
  id: number;
  name: string;
  surname: string;
  email: string;
  phoneNumber?: string;
  location: string;
}

export interface ProposalPropertyItem {
  id: number;
  customValue: string;
  // TODO: change to additional interface with ["parentPropertyValue": "string"] if needed after discussion with BE
  propertyDefinition: ParentDictionaryItem;
  // TODO: change to additional interface with ["parentPropertyValue": "string"] if needed after discussion with BE
  predefinedValue: ExpandedPropertyValue;
}

export interface ProposalItem {
  isActive: boolean;
  petOrigin: PetOrigin;
  title: string;
  petName: string;
  price: number;
  summary: string;
  location: string;
  id: number;
  createdOn: string;
  lastModifiedOn: string;
  age: number;
  ageUnits: number;
  photos: PhotoItem[];
  properties: ProposalPropertyItem[];
  appUser: ProposalUser;
}

export interface ProposalResponse {
  items: ProposalItem[];
  totalCount: number;
}

export interface Token {
  access_token: string;
  token_type: string;
}

export interface PetRequestBody {
  isActive: boolean;
  petOrigin: PetOrigin;
  title: string;
  price: number;
  summary: string;
  location: string;
  age: number;
  ageUnits: number;
  photos: PhotoItem[];
  properties: PropertiesRequestBody;
}

export interface PropertyDefinition {
  id: number;
  name: string;
}

export interface AdProperties {
  propertyDefinition: PropertyDefinition;
  predefinedValue: PropertyValue;
}

export interface ChipsItemRequest {
  customValue: string;
  propertyDefinition: PropertyDefinition;
}

export type PropertiesRequestBody = [
  AdProperties,
  AdProperties,
  AdProperties,
  AdProperties,
  ChipsItemRequest[],
  ChipsItemRequest[],
];

export interface MainFilterForm {
  animalType: FormControl<ExpandedPropertyValue | null>;
  location: FormControl<string | null>;
}

export interface FilterFormValue {
  animalType: ExpandedPropertyValue;
  breed: ExpandedPropertyValue;
  location: string;
  petOrigin: FilterPetOrigin;
  minPrice: number;
  maxPrice: number;
  sex: string;
  age: number;
  ageUnit: PERIOD_TYPES;
  maxAge: number;
  maxAgeUnit: PERIOD_TYPES;
  health: ChipsItem[];
  documents: ChipsItem[];
}

export interface MainViewDetails {
  title: string;
  price: number;
  age: string;
  location: string;
  sex: string;
  summary: string;
}

export interface ViewDetails extends MainViewDetails {
  photos: string;
}

export interface FullViewDetails extends MainViewDetails {
  userName: string;
  phoneNumber: string;
  animalType: string;
  breed: string;
  color: string;
  origin: string;
  health: ChipsItem[];
  documents: ChipsItem[];
  photos: PhotoItem[];
}

export interface FilterPetOrigin {
  value: PetOrigin;
  label: string;
}
