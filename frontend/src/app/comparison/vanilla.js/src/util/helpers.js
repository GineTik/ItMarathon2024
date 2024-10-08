import { AGE_CONFIG } from '../app.config.js';
import { createRenderFunction, createSvg, renderLi, renderUse } from './renderElements.js';

export const getRootElement = () => document.querySelector('#root');
export const rootElement = getRootElement();

export const fillListItems = (parentElement, childrenArray, liProps) => {
  childrenArray.forEach(childEntity => {
    const liElement = renderLi(parentElement, liProps);

    Array.isArray(childEntity) ? liElement.append(...childEntity) : liElement.appendChild(childEntity);
  });
};

export const createFragmentSvg = (svgProps = {}) => {
  const svg = createSvg(svgProps);

  renderUse(svg, svgProps.use);

  return svg;
};

export const renderFragmentSvg = createRenderFunction(createFragmentSvg);

export const formatPrice = price => {
  const formatter = new Intl.NumberFormat('uk-UA', {
    style: 'decimal',
    minimumFractionDigits: 2,
    maximumFractionDigits: 2,
  });
  const formattedPrice = formatter.format(price);

  return '₴ ' + formattedPrice.replace(',', ', ');
};

export const formatAge = (age, ageUnits) => {
  ageUnits = ageUnits || 1;

  const ageNumber = Math.floor(age / ageUnits);
  const ageUnitString = Object.entries(AGE_CONFIG).find(([unitName, unitNumber]) => unitNumber === ageUnits)?.[0];

  return ageNumber + ' ' + ageUnitString;
};

export const combineClasses = (firstProps, secondProps) => [
  ...(firstProps.classes || []),
  ...(secondProps.classes || []),
];

export const combineProps = (firstProps, secondProps) => ({
  ...firstProps,
  ...secondProps,
  classes: combineClasses(firstProps, secondProps),
});
