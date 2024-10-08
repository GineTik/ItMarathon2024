import { PROPERTY_IDS } from '../app.config.js';

export const getProposalSex = properties =>
  properties.find(property => property.propertyDefinition.id === PROPERTY_IDS.sex)?.predefinedValue?.value;

export const findPropertyByName = (propertyDefinitions, propertyName) =>
  propertyDefinitions.find(property => property.name === propertyName);

export const findPropertyId = (propertyDefinitions, propertyName) =>
  findPropertyByName(propertyDefinitions, propertyName)?.id;

export const findPredefinedValueId = (propertyDefinitions, propertyName, targetValue) => {
  const property = findPropertyByName(propertyDefinitions, propertyName);
  const predefinedValueId = property.propertyValues.find(value => value.value === targetValue)?.id;

  return predefinedValueId;
};
