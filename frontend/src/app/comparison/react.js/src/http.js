import { ERROR_MESSAGES, INPUT_LABELS } from './app.config';
import { findPredefinedValueId, findPropertyId } from './util';

const BASE_URL = 'https://dotnet-v4itmarathon-prod.azurewebsites.net/api/';
const propertyDefinitionsUrl = BASE_URL + '/property-definitions';
const proposalsUrl = BASE_URL + '/proposals';
// const proposalsUrl = BASE_URL + '/proposal'; // to test error case

export const fetchPropertyDefinitions = async () => {
  try {
    const response = await fetch(propertyDefinitionsUrl);

    if (!response.ok) {
      throw new { message: ERROR_MESSAGES.cantLoadPropertyDefinitions }();
    }

    return await response.json();
  } catch (error) {
    console.log(error);
  }
};

export const fetchNewestAds = async () => {
  const url = proposalsUrl + '?$top=10&$skip=0&$filter=IsActive eq true&$orderby=Price asc, CreatedOn desc';
  const response = await fetch(url);

  if (!response.ok) {
    throw { message: ERROR_MESSAGES.cantLoadNewestAds };
  }

  const petCardsData = await response.json();

  return petCardsData.items;
};

export const fetchFilteredAds = async (searchParams, propertyDefinitions) => {
  try {
    const animalType = searchParams.animalType;
    const animalTypePropertyId = findPropertyId(propertyDefinitions, INPUT_LABELS.animalType);
    const animalTypeValueId = findPredefinedValueId(propertyDefinitions, INPUT_LABELS.animalType, animalType);
    const location = searchParams.location;

    const animalTypeQueryString = ` and Properties/any(p:p/PropertyDefinition/Id eq ${animalTypePropertyId} and p/PredefinedValue/Id eq ${animalTypeValueId})`;
    const locationQueryString = ` and location eq ${location}`;

    const filterString = '' + (animalType ? animalTypeQueryString : '') + (location ? locationQueryString : '');

    const proposalQueryString = `?$top=10&$skip=0&$filter=IsActive eq true${filterString}&$orderby=Price asc, CreatedOn desc`;

    const url = proposalsUrl + proposalQueryString;
    const response = await fetch(url);

    if (!response.ok) {
      throw { message: ERROR_MESSAGES.cantLoadFilteredAds };
    }

    const petCardsData = await response.json();

    return petCardsData.items;
  } catch (error) {
    console.log(error);
  }
};
