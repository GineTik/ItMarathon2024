import { formatAge, formatPrice } from '../../../util/helpers.js';
import {
  addAttribute,
  createArticle,
  createRenderFunction,
  renderDiv,
  renderH3,
  renderImg,
  renderLi,
  renderSpan,
  renderUl,
} from '../../../util/renderElements.js';
import { getProposalSex } from '../../../util/extractors.js';
import { petCardProps } from './pet-card.config.js';

export const createPetCard = ({ location, age, ageUnits, id, title, price, photos, properties }) => {
  const detailsProps = petCardProps.details;
  const detailsItemProps = detailsProps.item;

  const detailsEntries = Object.entries({
    location: location,
    sex: getProposalSex(properties),
    age: formatAge(age, ageUnits),
  });

  let detailProps;

  const handleRedirect = () => {
    // handle redirect...
    console.log(`redirect to pet-card [id: ${id}]...`);
  };

  const petCard = createArticle(petCardProps);
  petCard.addEventListener('click', handleRedirect);

  const petPhoto = renderImg(petCard, petCardProps.photo);
  addAttribute('src', petPhoto, photos[0]?.url);

  const description = renderDiv(petCard, petCardProps.description);
  const titleElement = renderH3(description, petCardProps.cardTitle);
  addAttribute('textContent', titleElement, title);

  const details = renderUl(description, detailsProps);

  detailsEntries.forEach(([detailName, detailValue]) => {
    detailProps = { ...detailsItemProps };
    detailProps.classes.push(...detailsItemProps[`${detailName}Classes`]);
    detailProps.textContent = detailValue;

    renderLi(details, detailProps);
  });

  const priceElement = renderSpan(description, petCardProps.price);
  addAttribute('textContent', priceElement, formatPrice(price));

  return petCard;
};

export const renderPetCard = createRenderFunction(createPetCard);
