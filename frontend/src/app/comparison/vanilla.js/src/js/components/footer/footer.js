import { renderFragmentSvg } from '../../../util/helpers.js';
import {
  createDiv,
  createRenderFunction,
  renderAddress,
  renderAnchor,
  renderDiv,
  renderFooter,
  renderH3,
  renderParagraph,
} from '../../../util/renderElements.js';
import { globalFooterProps as footerProps } from './footer.config.js';

export const createGlobalFooter = () => {
  const mainInfoProps = footerProps.mainInfo;
  const addressProps = footerProps.address;
  const legalInfoProps = footerProps.legalInfo;

  const footerWrapper = createDiv(footerProps.wrapper);
  const globalFooter = renderFooter(footerWrapper, footerProps);

  const mainInfo = renderDiv(globalFooter, mainInfoProps);
  const mainInfoLink = renderAnchor(mainInfo, mainInfoProps.link);
  renderFragmentSvg(mainInfoLink, mainInfoProps.logotypeSvg);

  const address = renderAddress(mainInfo, addressProps);
  renderH3(address, addressProps.header);
  renderAnchor(address, addressProps.link);

  const legalInfo = renderParagraph(globalFooter, legalInfoProps);
  renderAnchor(legalInfo, legalInfoProps.link);

  return footerWrapper;
};

export const renderGlobalFooter = createRenderFunction(createGlobalFooter);
