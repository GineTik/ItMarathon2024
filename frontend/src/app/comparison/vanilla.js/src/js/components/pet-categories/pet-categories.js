import { PET_CATEGORIES } from '../../../app.config.js';
import { fillListItems } from '../../../util/helpers.js';
import {
  addAttribute,
  addClasses,
  createDiv,
  createRenderFunction,
  createSpan,
  renderUl,
} from '../../../util/renderElements.js';
import { petCategoriesProps as categoriesProps } from './pet-categories.config.js';

export const createPetCategories = (petCategoriesProps = {}) => {
  const categoryProps = categoriesProps.category;

  const categotiesWrapper = createDiv(categoriesProps.wrapper);
  addClasses(categotiesWrapper, petCategoriesProps.classes);
  const categories = renderUl(categotiesWrapper, categoriesProps);

  const categoriesChildren = PET_CATEGORIES.map(category => {
    const amount = createSpan(categoryProps.categoryAmount);
    addAttribute('textContent', amount, category.amount);
    const name = createSpan(categoryProps.categoryName);
    addAttribute('textContent', name, category.name);

    return [amount, name];
  });

  fillListItems(categories, categoriesChildren, categoriesProps.category);

  return categotiesWrapper;
};

export const renderPetCategories = createRenderFunction(createPetCategories);
