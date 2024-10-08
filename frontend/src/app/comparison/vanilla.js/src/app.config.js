export const TAGS = {
  address: 'address',
  anchor: 'a',
  article: 'article',
  aside: 'aside',
  button: 'button',
  div: 'div',
  footer: 'footer',
  form: 'form',
  h1: 'h1',
  h2: 'h2',
  h3: 'h3',
  header: 'header',
  img: 'img',
  label: 'label',
  li: 'li',
  main: 'main',
  nav: 'nav',
  option: 'option',
  paragraph: 'p',
  section: 'section',
  select: 'select',
  span: 'span',
  ul: 'ul',
};

export const NAMESPACES = {
  svg: 'http://www.w3.org/2000/svg',
  xlink: 'http://www.w3.org/1999/xlink',
};

export const NAMESPACE_TAGS = {
  path: 'path',
  svg: 'svg',
  use: 'use',
};

export const BUTTON_CONTENT = {
  googleRegister: 'Зареєструватися за допомогою Google',
  googleLogin: 'Увійти за допомогою Google',
  sendPassword: 'Надіслати пароль',
  sendCode: 'Надіслати код',
  register: 'Зареєструватися',
  backToLogin: 'Повернутися до входу',
  understood: 'Зрозуміло',
  viewPetCard: 'Переглянути оголошення',
  login: 'Увійти',
  search: 'Шукати',
  addAnnouncement: 'Додати оголошення',
  showMore: 'Показати ще',
  deactivate: 'Деактивувати',
  edit: 'Редагувати',
  back: 'Назад',
  publish: 'Опублікувати',
  no: 'Ні',
  yes: 'Так',
  changePassword: 'Змінити пароль',
  reloadPage: 'Оновити сторінку',
  goToMain: 'Перейти на головну',
};

export const PLACEHOLDERS = {
  location: 'Оберіть локацію',
  price: 'Введіть ціну',
  adTitle: 'Введіть назву оголошення',
  animalType: 'Оберіть вид тварини',
  age: 'Введіть вік',
  period: 'Період',
  breed: 'Оберіть різновид',
  sort: 'Сортувати за',
  chooseColor: 'Оберіть забарвлення',
  ownerType: 'Оберіть походження',
  email: 'Введіть вашу пошту',
  password: 'Введіть пароль',
  confirmPassword: 'Повторіть пароль',
  name: 'Введіть імʼя',
  surname: 'Введіть прізвище',
};

export const PET_CATEGORIES = [
  {
    amount: 150,
    name: 'Собак',
  },
  {
    amount: 135,
    name: 'Птахів',
  },
  {
    amount: 110,
    name: 'Котів',
  },
  {
    amount: 50,
    name: 'Гризунів',
  },
  {
    amount: 10,
    name: 'Рептилій',
  },
];

export const PET_CARDS_MOCK = [
  {
    id: 1,
    age: '3-5 років',
    description:
      'Вакцинований, кастрований, привчений до туалету (наповнювач), дуже чистоплотний. Має звичку спати на ліжку та грати з іграшками. Харчується якісним сухим кормом.',
    image: './src/assets/tmp/dog.png',
    location: 'Камʼянець подільський',
    price: 2100.9,
    sex: 'Дівчинка',
    title: 'Продам дуже хорошу та слухняну собаку',
  },
  {
    id: 2,
    age: '3-5 років',
    description:
      'Вакцинований, кастрований, привчений до туалету (наповнювач), дуже чистоплотний. Має звичку спати на ліжку та грати з іграшками. Харчується якісним сухим кормом.',
    image: './src/assets/tmp/dog.png',
    location: 'Камʼянець подільський',
    price: 2100.9,
    sex: 'Дівчинка',
    title: 'Продам дуже хорошу та слухняну собаку',
  },
  {
    id: 3,
    age: '3-5 років',
    description:
      'Вакцинований, кастрований, привчений до туалету (наповнювач), дуже чистоплотний. Має звичку спати на ліжку та грати з іграшками. Харчується якісним сухим кормом.',
    image: './src/assets/tmp/dog.png',
    location: 'Камʼянець подільський',
    price: 2100.9,
    sex: 'Дівчинка',
    title: 'Продам дуже хорошу та слухняну собаку',
  },
  {
    id: 4,
    age: '3-5 років',
    description:
      'Вакцинований, кастрований, привчений до туалету (наповнювач), дуже чистоплотний. Має звичку спати на ліжку та грати з іграшками. Харчується якісним сухим кормом.',
    image: './src/assets/tmp/dog.png',
    location: 'Камʼянець подільський',
    price: 2100.9,
    sex: 'Дівчинка',
    title: 'Продам дуже хорошу та слухняну собаку',
  },
];

export const ANIMAL_TYPES = ['Собаки', 'Коти', 'Гризуни', 'Риби', 'Птахи', 'Рептилії', 'Інші'];

export const CITY_LIST = [
  'Абрамівська Долина',
  'Київ',
  'Харків',
  'Одеса',
  'Дніпро',
  'Запоріжжя',
  'Львів',
  'Миколаїв ',
  'Вінниця',
  'Полтава',
];

export const PROPERTY_IDS = {
  sex: 3,
};

export const PROPERTY_NAMES = {
  animalType: 'Вид тварини',
  location: 'Локація',
};

export const PERIOD_TYPES = {
  days: 'Днів',
  weeks: 'Тижнів',
  months: 'Місяців',
  years: 'Років',
};

export const AGE_CONFIG = {
  [PERIOD_TYPES.days]: 1,
  [PERIOD_TYPES.weeks]: 7,
  [PERIOD_TYPES.months]: 30,
  [PERIOD_TYPES.years]: 365,
};
