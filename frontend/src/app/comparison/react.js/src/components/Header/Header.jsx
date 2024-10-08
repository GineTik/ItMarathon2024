import './Header.scss';

import { BUTTON_CONTENT } from '../../app.config';
import Button from '../ui/Button/Button';

export default function Header() {
  const onAddNewAdvertisement = () => {}; // redirect

  return (
    <div className="main-header-wrapper">
      <header className="main-header app-container">
        <nav className="nav-header">
          <ul className="nav-header__links">
            <li>
              <ul className="nav-header__main-links">
                <li>
                  <a href="#" title="На головну">
                    <svg width="178" height="46">
                      <use xlinkHref="/assets/icons/sprite-logotypes.svg#header-logo" />
                    </svg>
                  </a>
                </li>
                <li>
                  <a className="nav-header__link-ads" href="#">
                    Оголошення
                  </a>
                </li>
              </ul>
            </li>
            <li>
              <ul className="nav-header__side-links">
                <li>
                  <Button className="add" onClick={onAddNewAdvertisement}>
                    {BUTTON_CONTENT.addAnnouncement}
                  </Button>
                </li>
                <li>
                  <a className="nav-header__link-profile" href="#">
                    <div className="nav-header__avatar-wrapper">
                      <img
                        src="/assets/icons/sprite-icons-small.svg#avatar-placeholder"
                        alt="Аватар акаунта"
                        width="32"
                        height="32"
                      />
                    </div>
                    Акаунт
                  </a>
                </li>
              </ul>
            </li>
          </ul>
        </nav>
      </header>
    </div>
  );
}
