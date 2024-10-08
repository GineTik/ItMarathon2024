import { BUTTON_CONTENT } from '../../../app.config.js';

export const globalHeaderProps = {
  classes: ['global-header', 'app-container'],
  headerLinks: {
    classes: ['header-links'],
  },
  mainLinks: {
    classes: ['main-links'],
    toMainLink: {
      href: '#',
      title: 'На головну',
    },
    linkAds: {
      classes: ['link-ads'],
      href: '#',
      textContent: 'Оголошення',
    },
    logotypeSvg: {
      height: 46,
      use: {
        xlinkHref: './src/assets/icons/sprite-logotypes.svg#header-logo',
      },
      width: 178,
    },
  },
  navHeader: {
    classes: ['nav-header'],
  },
  sideLinks: {
    addAdButton: {
      classes: ['add'],
      textContent: BUTTON_CONTENT.addAnnouncement,
    },
    classes: ['side-links'],
    linkProfile: {
      classes: ['link-profile'],
      href: '#',
      textContent: 'Акаунт',
    },
  },
  wrapper: {
    classes: ['header-wrapper'],
  },
};
