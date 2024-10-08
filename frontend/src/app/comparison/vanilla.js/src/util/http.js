import { PROPERTY_NAMES } from '../app.config.js';
import { hideLoader, showLoader } from '../js/components/loader/loader.js';
import { showToaster } from '../js/components/toaster/toaster.js';
import { findPredefinedValueId, findPropertyId } from './extractors.js';

const BASE_URL = 'https://dotnet-v4itmarathon-prod.azurewebsites.net/api';
const propertyDefinitionsUrl = BASE_URL + '/property-definitions';
const proposalsUrl = BASE_URL + '/proposals';

export let propertyDefinitions = [];

export const parseResponseErrorText = async response => {
  return response.body
    .getReader()
    .read()
    .then(({ value }) => {
      const decoder = new TextDecoder();

      return decoder.decode(value);
    });
};

export const fetchUrl = async (url, options) => {
  showLoader();

  try {
    const response = await fetch(url, options);

    if (!response.ok) {
      throw { message: (await parseResponseErrorText(response)) || 'Failed to fetch data.' };
    }

    return await response.json();
  } catch (error) {
    return {
      isError: true,
      error,
    };
  } finally {
    hideLoader();
  }
};

export const fetchPropertyDefinitions = async () => {
  const data = await fetchUrl(propertyDefinitionsUrl);

  if (data.isError) {
    console.log(data.error);

    return;
  }

  propertyDefinitions = data;
};

fetchPropertyDefinitions();

export const fetchNewestAds = async () => {
  const url = proposalsUrl + '?$top=4&$filter=IsActive eq true&$orderby=CreatedOn desc';
  const newestAds = await fetchUrl(url);

  if (newestAds.isError) {
    showToaster({ type: 'error', message: newestAds.error.message });

    return;
  }

  return newestAds.items;
};

export const fetchFilteredAds = async (searchParams, propertyDefinitions) => {
  const animalType = searchParams.animalType;
  const animalTypePropertyId = findPropertyId(propertyDefinitions, PROPERTY_NAMES.animalType);
  const animalTypeValueId = findPredefinedValueId(propertyDefinitions, PROPERTY_NAMES.animalType, animalType);
  const location = searchParams.location;

  const animalTypeQueryString = ` and Properties/any(p:p/PropertyDefinition/Id eq ${animalTypePropertyId} and p/PredefinedValue/Id eq ${animalTypeValueId})`;
  const locationQueryString = ` and Location eq '${location}'`;

  const filterString = '' + (animalType ? animalTypeQueryString : '') + (location ? locationQueryString : '');

  const proposalQueryString = `?$top=10&$skip=0&$filter=IsActive eq true${filterString}&$orderby=Price asc, CreatedOn desc`;

  const url = proposalsUrl + proposalQueryString;
  const filteredAds = await fetchUrl(url);

  if (filteredAds.isError) {
    showToaster({ type: 'error', message: filteredAds.error.message });

    return;
  }

  return filteredAds.items;
};
