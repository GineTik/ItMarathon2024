import './PetCard.scss';

import { formatPrice } from '../../util';

export default function PetCard({ isHorizontal, isEditable, petCard }) {
  const { image, title, location, sex, age, price, summary } = petCard;
  const petCardClass = 'pet-card' + (isHorizontal ? ' horizontal' : '');
  const imageHeight = isHorizontal ? 208 : 272;
  const formattedPrice = formatPrice(price);

  const detailsEntries = Object.entries({ location, sex, age });

  const editButton = (
    <button className="edit-button">
      <svg className="edit-button__icon" width="24" height="24">
        <use xlinkHref="/assets/icons/sprite-icons-small.svg#pencil" />
      </svg>
    </button>
  );

  const descriptionElement = <p className="description-text">{summary}</p>;

  return (
    <article className={petCardClass}>
      {isEditable && editButton}

      <img className="photo" src={image} alt="Зображення тваринки" width="288" height={imageHeight} />
      <div className="description">
        <h3 className="title">{title}</h3>

        {isHorizontal && descriptionElement}

        <ul className="details">
          {detailsEntries.map(([detailName, detailValue]) => (
            <li key={detailName} className={`details__item details__item--${detailName}`}>
              {detailValue}
            </li>
          ))}
        </ul>
        <span className="price">{formattedPrice}</span>
      </div>
    </article>
  );
}
