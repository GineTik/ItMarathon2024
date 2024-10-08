import { NAMESPACES, NAMESPACE_TAGS, TAGS } from '../app.config.js';

export const createRenderFunction =
  createElementFn =>
  (parentElement, elementProps = {}) =>
    parentElement.appendChild(createElementFn(elementProps));

export const addClasses = (element, elementClasses) => {
  if (elementClasses) {
    element.classList.add(...elementClasses);
  }
};

export const addAttribute = (attributeName, element, attributeValue) => {
  if (attributeValue) {
    element[attributeName] = attributeValue;
  }
};

export const setAttribute = (attributeName, element, attributeValue) => {
  if (attributeValue) {
    element.setAttribute(attributeName, attributeValue);
  }
};

export const setAttributeNS = (namespace, attributeName, element, attributeValue) => {
  if (attributeValue) {
    element.setAttributeNS(namespace, attributeName, attributeValue);
  }
};

const createElement = (tag, elementProps = {}) => {
  const element = document.createElement(tag);

  addClasses(element, elementProps.classes);
  addAttribute('href', element, elementProps.href);
  addAttribute('target', element, elementProps.target);
  addAttribute('title', element, elementProps.title);
  addAttribute('src', element, elementProps.src);
  addAttribute('alt', element, elementProps.alt);
  addAttribute('width', element, elementProps.width);
  addAttribute('height', element, elementProps.height);
  addAttribute('role', element, elementProps.role);
  addAttribute('viewBox', element, elementProps.viewBox);
  addAttribute('name', element, elementProps.name);
  addAttribute('value', element, elementProps.value);
  addAttribute('disabled', element, elementProps.disabled);
  addAttribute('selected', element, elementProps.selected);
  addAttribute('textContent', element, elementProps.textContent);

  return element;
};

const renderElement = (tag, parentElement, elementProps = {}) =>
  parentElement.appendChild(createElement(tag, elementProps));

const createTagFunctions = (tagsObject, isRender = false) => {
  const tagsEntries = Object.entries(tagsObject);

  return tagsEntries.reduce((tagFunctions, [tagName, tagValue]) => {
    const functionName = isRender
      ? `render${tagName[0].toUpperCase()}${tagName.slice(1)}`
      : `create${tagName[0].toUpperCase()}${tagName.slice(1)}`;

    tagFunctions[functionName] = isRender
      ? (parentElement, elementProps) => renderElement(tagValue, parentElement, elementProps)
      : elementProps => createElement(tagValue, elementProps);

    return tagFunctions;
  }, {});
};

const isRender = true;
const createFunctions = createTagFunctions(TAGS);
const renderFunctions = createTagFunctions(TAGS, isRender);

createFunctions.createSvg = (svgProps = {}) => {
  const svg = document.createElementNS(NAMESPACES.svg, NAMESPACE_TAGS.svg);

  addClasses(svg, svgProps.classes);
  setAttribute('width', svg, svgProps.width);
  setAttribute('height', svg, svgProps.height);
  setAttribute('viewBox', svg, svgProps.viewBox);

  return svg;
};

createFunctions.createUse = (useProps = {}) => {
  const use = document.createElementNS(NAMESPACES.svg, NAMESPACE_TAGS.use);

  setAttributeNS(NAMESPACES.xlink, 'xlink:href', use, useProps.xlinkHref);

  return use;
};

createFunctions.createPath = (pathProps = {}) => {
  const path = document.createElementNS(NAMESPACES.svg, NAMESPACE_TAGS.path);

  setAttribute('d', path, pathProps.d);

  return path;
};

renderFunctions.renderSvg = createRenderFunction(createFunctions.createSvg);
renderFunctions.renderUse = createRenderFunction(createFunctions.createUse);
renderFunctions.renderPath = createRenderFunction(createFunctions.createPath);

export const {
  createAddress,
  createAnchor,
  createArticle,
  createAside,
  createButton,
  createDiv,
  createFooter,
  createForm,
  createH1,
  createH2,
  createH3,
  createHeader,
  createImg,
  createLabel,
  createLi,
  createMain,
  createNav,
  createOption,
  createParagraph,
  createPath,
  createSection,
  createSelect,
  createSpan,
  createSvg,
  createUl,
  createUse,
} = createFunctions;

export const {
  renderAddress,
  renderAnchor,
  renderArticle,
  renderAside,
  renderButton,
  renderDiv,
  renderFooter,
  renderForm,
  renderH1,
  renderH2,
  renderH3,
  renderHeader,
  renderImg,
  renderLabel,
  renderLi,
  renderMain,
  renderNav,
  renderOption,
  renderParagraph,
  renderPath,
  renderSection,
  renderSelect,
  renderSpan,
  renderSvg,
  renderUl,
  renderUse,
} = renderFunctions;
