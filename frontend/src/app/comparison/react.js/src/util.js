import { PROPERTY_IDS } from './app.config';

export const formatPrice = price => {
  const formatter = new Intl.NumberFormat('uk-UA', {
    style: 'decimal',
    minimumFractionDigits: 2,
    maximumFractionDigits: 2,
  });
  const formattedPrice = formatter.format(price);

  return '₴ ' + formattedPrice.replace(',', ', ');
};

export const findPropertyByName = (propertyDefinitions, propertyName) =>
  propertyDefinitions.find(property => property.name === propertyName);

export const findPropertyId = (propertyDefinitions, propertyName) =>
  findPropertyByName(propertyDefinitions, propertyName)?.id;

export const findPredefinedValueId = (propertyDefinitions, propertyName, targetValue) => {
  const property = findPropertyByName(propertyDefinitions, propertyName);
  const predefinedValueId = property.propertyValues.find(value => value.value === targetValue)?.id;

  return predefinedValueId;
};

export const getProposalSex = petCard =>
  petCard.properties.find(property => property.propertyDefinition.id === PROPERTY_IDS.sex)?.predefinedValue?.value;
