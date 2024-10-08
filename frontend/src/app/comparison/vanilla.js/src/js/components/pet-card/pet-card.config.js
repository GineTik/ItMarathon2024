export const petCardProps = {
  cardTitle: {
    classes: ['title'],
  },
  classes: ['pet-card'],
  details: {
    classes: ['details'],
    item: {
      ageClasses: ['details__item--age'],
      classes: ['details__item'],
      locationClasses: ['details__item--location'],
      sexClasses: ['details__item--sex'],
    },
  },
  description: {
    classes: ['description'],
  },
  photo: {
    alt: 'Зображення тваринки',
    classes: ['photo'],
    height: 272,
    width: 288,
  },
  price: {
    classes: ['price'],
  },
};
