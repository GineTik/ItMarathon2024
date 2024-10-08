import { rootElement } from '../../../util/helpers.js';
import { createDiv, renderPath, renderSvg } from '../../../util/renderElements.js';
import { globalLoaderProps } from './loader.config.js';

let loader;
let activeRequests = 0;

export const createLoader = () => {
  if (loader) return loader;

  const svgProps = globalLoaderProps.svg;

  loader = createDiv(globalLoaderProps);
  const loaderSvg = renderSvg(loader, svgProps);

  const pathsProps = [svgProps.path1, svgProps.path2, svgProps.path3, svgProps.path4, svgProps.path5];
  pathsProps.forEach(pathProps => renderPath(loaderSvg, pathProps));

  return loader;
};

loader = createLoader();

export const renderLoader = () => rootElement.appendChild(loader);
export const removeLoader = () => loader.remove();

export const showLoader = () => {
  activeRequests++;

  if (activeRequests === 1) {
    renderLoader();
  }
};

export const hideLoader = () => {
  if (activeRequests <= 0) return;

  activeRequests--;

  if (activeRequests === 0) {
    removeLoader();
  }
};
