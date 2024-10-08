export const globalFooterProps = {
  address: {
    classes: ['address'],
    header: {
      classes: ['header'],
      textContent: 'Контакти',
    },
    link: {
      classes: ['link-footer'],
      href: 'mailto:support@petworld.pet',
      target: '_blank',
      textContent: 'support@petworld.pet',
    },
  },
  classes: ['global-footer', 'app-container'],
  legalInfo: {
    classes: ['legal-info'],
    link: {
      classes: ['link-footer'],
      href: '#',
      target: '_blank',
      textContent: 'Політика конфіденційності',
    },
    textContent: 'Copyright 2024 | ',
  },
  mainInfo: {
    classes: ['main-info'],
    link: {
      href: '#',
      title: 'На головну',
    },
    logotypeSvg: {
      height: 56,
      use: {
        xlinkHref: './src/assets/icons/sprite-logotypes.svg#footer-logo',
      },
      width: 204,
    },
  },
  wrapper: {
    classes: ['footer-wrapper'],
  },
};
