import { CITY_LIST } from '../../../app.config.js';
import { ANIMAL_TYPES } from '../../../app.config.js';
import { combineProps } from '../../../util/helpers.js';
import { fetchFilteredAds, propertyDefinitions } from '../../../util/http.js';
import { createForm, createRenderFunction } from '../../../util/renderElements.js';
import { renderMainButton } from '../button/button.js';
import { renderCustomSelect } from '../select/select.js';
import { searchFormProps } from './search-form.config.js';

const handleSubmit = event => {
  event.preventDefault();

  const formData = new FormData(event.target);
  const data = Object.fromEntries(formData.entries());
  const searchParams = {
    animalType: data[searchFormProps.animalTypeSelect.name],
    location: data[searchFormProps.locationSelect.name],
  };

  // redirect...
  // openPetsPage(searchParams);
  console.log('redirect to filter page...');

  // then later fetch data
  const fetchData = async () => {
    const filteredAds = await fetchFilteredAds(searchParams, propertyDefinitions);

    console.log('filteredAds: ', filteredAds);
  };

  fetchData();
};

export const createSearchForm = () => {
  const selectProps = searchFormProps.select;
  const animalTypeSelectProps = combineProps(selectProps, searchFormProps.animalTypeSelect);
  const locationSelectProps = combineProps(selectProps, searchFormProps.locationSelect);

  const animalTypeOptions = ANIMAL_TYPES.map(animalType => ({ textContent: animalType, value: animalType }));
  const cityListOptions = CITY_LIST.map(cityList => ({ textContent: cityList, value: cityList }));

  const searchForm = createForm(searchFormProps);
  searchForm.addEventListener('submit', handleSubmit);

  renderCustomSelect(searchForm, animalTypeOptions, animalTypeSelectProps);
  renderCustomSelect(searchForm, cityListOptions, locationSelectProps);
  renderMainButton(searchForm, searchFormProps.submitButton);

  return searchForm;
};

export const renderSearchForm = createRenderFunction(createSearchForm);
