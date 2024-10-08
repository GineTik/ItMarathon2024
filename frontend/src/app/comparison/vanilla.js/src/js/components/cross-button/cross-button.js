import { combineProps, renderFragmentSvg } from '../../../util/helpers.js';
import { createButton, createRenderFunction } from '../../../util/renderElements.js';
import { crossButtonProps } from './cross-button.config.js';

export const createCrossButton = (buttonProps = {}) => {
  const finalButtonProps = combineProps(crossButtonProps, buttonProps);
  const crossButton = createButton(finalButtonProps);

  renderFragmentSvg(crossButton, finalButtonProps.iconSvg);

  return crossButton;
};

export const renderCrossButton = createRenderFunction(createCrossButton);
