import { useContext, useState } from 'react';
import { FormControl, InputLabel, MenuItem, Select } from '@mui/material';

import './SearchForm.scss';

import { ANIMAL_TYPES, BUTTON_CONTENT, CITY_LIST, INPUT_LABELS, PLACEHOLDERS } from '../../app.config';
import { fetchFilteredAds } from '../../http';
import Button from '../ui/Button/Button';
import { PropertyDefinitionsContext } from '../../store/PropertyDefinitionsContext';

const searchParamsInitial = {
  animalType: '',
  location: '',
};

export default function SearchForm() {
  const { definitions: propertyDefinitions } = useContext(PropertyDefinitionsContext);

  const [searchParams, setSearchParams] = useState(searchParamsInitial);

  const resetSearchParams = () => setSearchParams(searchParamsInitial);

  const handleChangeSelect = (event, selector) =>
    setSearchParams(prevValue => ({
      ...prevValue,
      [selector]: event.target.value,
    }));

  const handleSubmit = event => {
    event.preventDefault();
    resetSearchParams();

    // redirect...
    console.log('redirect...');

    // then later fetch data
    if (!searchParams.animalType && !searchParams.location) return;

    const fetchData = async () => {
      const filteredAds = await fetchFilteredAds(searchParams, propertyDefinitions);

      console.log('filteredAds: ', filteredAds);
    };

    fetchData();
  };

  return (
    <form className="search-form" onSubmit={handleSubmit}>
      <FormControl>
        <InputLabel id="animal-type-select-label" shrink={true}>
          {INPUT_LABELS.animalType}
        </InputLabel>
        <Select
          className="search-form__select"
          labelId="animal-type-select-label"
          value={searchParams.animalType}
          id="animal-type-select"
          label={INPUT_LABELS.animalType}
          onChange={event => handleChangeSelect(event, 'animalType')}
          displayEmpty
          renderValue={selected => selected || PLACEHOLDERS.animalType}
        >
          {ANIMAL_TYPES.map(animalType => (
            <MenuItem key={animalType} value={animalType}>
              {animalType}
            </MenuItem>
          ))}
        </Select>
      </FormControl>

      <FormControl>
        <InputLabel id="location-select-label" shrink={true}>
          {INPUT_LABELS.location}
        </InputLabel>
        <Select
          className="search-form__select"
          labelId="location-select-label"
          value={searchParams.location}
          id="location-select"
          label={INPUT_LABELS.location}
          onChange={event => handleChangeSelect(event, 'location')}
          displayEmpty
          renderValue={selected => selected || PLACEHOLDERS.location}
        >
          {CITY_LIST.map(cityName => (
            <MenuItem key={cityName} value={cityName}>
              {cityName}
            </MenuItem>
          ))}
        </Select>
      </FormControl>

      <Button className="search search-form__search-button">{BUTTON_CONTENT.search}</Button>
    </form>
  );
}
