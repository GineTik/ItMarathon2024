import './Footer.scss';

export default function Footer() {
  return (
    <div className="main-footer-wrapper">
      <footer className="main-footer app-container">
        <div className="main-info">
          <a href="#" title="На головну">
            <svg width="204" height="56">
              <use xlinkHref="/assets/icons/sprite-logotypes.svg#footer-logo" />
            </svg>
          </a>
          <address className="address">
            <h3 className="header">Контакти</h3>
            <a className="link-footer" href="mailto:support@petworld.pet" target="_blank">
              support&#64;petworld.pet
            </a>
          </address>
        </div>
        <p className="legal-info">
          Copyright 2024 |{' '}
          <a className="link-footer" href="#" target="_blank">
            Політика конфіденційності
          </a>
        </p>
      </footer>
    </div>
  );
}
