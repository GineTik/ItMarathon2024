import { PLACEHOLDERS } from '../../../app.config.js';
import { BUTTON_CONTENT } from '../../../app.config.js';

export const searchFormProps = {
  animalTypeSelect: {
    defaultOption: PLACEHOLDERS.animalType,
    name: 'animal-type-select',
  },
  classes: ['search-form'],
  locationSelect: {
    defaultOption: PLACEHOLDERS.location,
    name: 'location-select',
  },
  select: {
    classes: ['search-form__select'],
  },
  submitButton: {
    classes: ['search'],
    textContent: BUTTON_CONTENT.search,
  },
};
