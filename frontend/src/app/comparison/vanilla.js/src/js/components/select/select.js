import { combineProps } from '../../../util/helpers.js';
import { createLabel, renderOption, renderSelect } from '../../../util/renderElements.js';
import { customSelectProps } from './select.config.js';

export const createCustomSelect = (options, selectProps = {}) => {
  const defaultOption = selectProps.defaultOption;
  const selectFinalProps = combineProps(customSelectProps, selectProps);

  const selectLabel = createLabel(customSelectProps.label);
  const select = renderSelect(selectLabel, selectFinalProps);

  if (defaultOption) {
    renderOption(select, {
      textContent: defaultOption,
      disabled: true,
      selected: true,
      value: '',
    });
  }

  options.forEach(option => renderOption(select, option));

  return select;
};

export const renderCustomSelect = (parentElement, options, selectProps = {}) =>
  parentElement.appendChild(createCustomSelect(options, selectProps));
