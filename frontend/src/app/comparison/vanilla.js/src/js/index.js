import { rootElement } from '../util/helpers.js';
import { renderGlobalFooter } from './components/footer/footer.js';
import { renderGlobalHeader } from './components/header/header.js';
import { renderMainPage } from './pages/main/main.js';

renderGlobalHeader(rootElement);
renderMainPage(rootElement);
renderGlobalFooter(rootElement);
