import { fillListItems } from '../../../util/helpers.js';
import { fetchNewestAds } from '../../../util/http.js';
import {
  createMain,
  createRenderFunction,
  renderDiv,
  renderH1,
  renderH2,
  renderHeader,
  renderSection,
  renderUl,
} from '../../../util/renderElements.js';
import { createPetCard } from '../../components/pet-card/pet-card.js';
import { renderPetCategories } from '../../components/pet-categories/pet-categories.js';
import { renderSearchForm } from '../../components/search-form/search-form.js';
import { mainPageProps as pageProps } from './main.config.js';

const renderNewestPetCards = (parentElement, newestAdsPromise) => {
  newestAdsPromise.then(newestAds => {
    const petCardsChildren = newestAds.map(petCard => createPetCard(petCard));
    fillListItems(parentElement, petCardsChildren);
  });
};

export const createMainPage = () => {
  const newestAdsPromise = fetchNewestAds();
  const newestAdsSectionProps = pageProps.newestAdsSection;

  const mainPage = createMain(pageProps);
  const mainContainer = renderDiv(mainPage, pageProps.container);

  const globalHeader = renderHeader(mainContainer, pageProps.globalHeader);
  renderH1(globalHeader, pageProps.mainHeader);
  renderSearchForm(globalHeader);

  renderPetCategories(mainContainer, pageProps.petCategories);

  const newestAdsSection = renderSection(mainContainer, newestAdsSectionProps);
  renderH2(newestAdsSection, newestAdsSectionProps.header);
  const petCardList = renderUl(newestAdsSection, newestAdsSectionProps.petCardList);

  renderNewestPetCards(petCardList, newestAdsPromise);

  return mainPage;
};

export const renderMainPage = createRenderFunction(createMainPage);
