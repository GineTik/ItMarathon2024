import { fillListItems, renderFragmentSvg } from '../../../util/helpers.js';
import {
  createAnchor,
  createDiv,
  createRenderFunction,
  createUl,
  renderHeader,
  renderNav,
  renderUl,
} from '../../../util/renderElements.js';
import { createMainButton } from '../button/button.js';
import { globalHeaderProps as headerProps } from './header.config.js';

export const createGlobalHeader = () => {
  const mainLinksProps = headerProps.mainLinks;
  const sideLinksProps = headerProps.sideLinks;

  const handleAddAdRedirect = () => {
    // redirect...
    console.log('redirect to create an ad page...');
  };

  const headerWrapper = createDiv(headerProps.wrapper);
  const globalHeader = renderHeader(headerWrapper, headerProps);
  const navHeader = renderNav(globalHeader, headerProps.navHeader);
  const headerLinks = renderUl(navHeader, headerProps.headerLinks);

  const mainLinks = createUl(mainLinksProps);
  const sideLinks = createUl(sideLinksProps);

  const toMainLink = createAnchor(mainLinksProps.toMainLink);
  const linkAds = createAnchor(mainLinksProps.linkAds);
  renderFragmentSvg(toMainLink, mainLinksProps.logotypeSvg);

  const addAdButton = createMainButton(sideLinksProps.addAdButton);
  addAdButton.addEventListener('click', handleAddAdRedirect);
  const linkProfile = createAnchor(sideLinksProps.linkProfile);

  const headerLinksChildren = [mainLinks, sideLinks];
  const mainLinksChildren = [toMainLink, linkAds];
  const sideLinksChildren = [addAdButton, linkProfile];

  fillListItems(headerLinks, headerLinksChildren);
  fillListItems(mainLinks, mainLinksChildren);
  fillListItems(sideLinks, sideLinksChildren);

  return headerWrapper;
};

export const renderGlobalHeader = createRenderFunction(createGlobalHeader);
