import { rootElement } from '../../../util/helpers.js';
import {
  createDiv,
  createRenderFunction,
  renderAside,
  renderImg,
  renderParagraph,
} from '../../../util/renderElements.js';
import { renderCrossButton } from '../cross-button/cross-button.js';
import { globalToasterProps } from './toaster.config.js';

let toasterWrapper;

export const createToaster = (toasterObject = {}) => {
  const toasterType = toasterObject.type;
  const toasterProps = {
    ...globalToasterProps,
    classes: [...(globalToasterProps.classes || []), toasterType],
  };
  const iconProps = {
    ...globalToasterProps.icon,
    src: globalToasterProps.icon.srcBase + toasterType,
  };
  const messageProps = {
    ...globalToasterProps.message,
    title: toasterObject.message,
    textContent: toasterObject.message,
  };

  toasterWrapper = createDiv(toasterProps.wrapper);
  const toaster = renderAside(toasterWrapper, toasterProps);

  renderImg(toaster, iconProps);
  renderParagraph(toaster, messageProps);
  const closeButton = renderCrossButton(toaster, { classes: [toasterType] });
  closeButton.addEventListener('click', hideToaster);

  return toasterWrapper;
};

export const renderToaster = createRenderFunction(createToaster);

export const showToaster = (toasterObject = {}) => {
  if (toasterWrapper) {
    hideToaster();
  }

  renderToaster(rootElement, toasterObject);
};

export const hideToaster = () => {
  if (!toasterWrapper) return;

  toasterWrapper.remove();
  toasterWrapper = null;
};
