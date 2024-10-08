import { combineProps } from '../../../util/helpers.js';
import { createButton, createRenderFunction } from '../../../util/renderElements.js';
import { mainButtonProps } from './button.config.js';

export const createMainButton = (buttonProps = {}) => createButton(combineProps(mainButtonProps, buttonProps));

export const renderMainButton = createRenderFunction(createMainButton);
