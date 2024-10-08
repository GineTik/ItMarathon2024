import { BUTTON_CONTENT } from '../../../app.config.js';

export const mainPageProps = {
  classes: ['main-page'],
  container: {
    classes: ['app-container'],
  },
  globalHeader: {
    classes: ['main-page__global-header'],
  },
  mainHeader: {
    classes: ['main-header'],
    textContent: 'Звідси починається найкраща дружба',
  },
  newestAdsSection: {
    classes: ['newest-ads-section'],
    header: {
      classes: ['newest-ads-section__header'],
      textContent: 'Найновіші оголошення',
    },
    petCardList: {
      classes: ['newest-ads-section__pet-cards'],
    },
  },
  petCategories: {
    classes: ['main-page__pet-categories'],
  },
};
