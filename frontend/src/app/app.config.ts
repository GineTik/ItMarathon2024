export enum ROUTING_LIST {
  auth = 'auth',
  pets = 'our-pets',
  signIn = 'sign-in',
  signUp = 'sign-up',
  confirmation = 'confirmation-page',
  forgotPassword = 'forgot-password',
  newPet = 'add-new-pet',
  preview = 'preview',
  test = 'test',
  createNewPassword = 'create-new-password',
  me = 'me',
}

export enum INPUT_TYPES {
  email = 'email',
  file = 'file',
  password = 'password',
  text = 'text',
  checkbox = 'checkbox',
  number = 'number',
}

export enum BUTTON_CONTENT {
  googleRegister = 'Зареєструватися за допомогою Google',
  googleLogin = 'Увійти за допомогою Google',
  sendPassword = 'Надіслати пароль',
  sendCode = 'Надіслати код',
  register = 'Зареєструватися',
  backToLogin = 'Повернутися до входу',
  understood = 'Зрозуміло',
  viewPetCard = 'Переглянути оголошення',
  login = 'Увійти',
  search = 'Шукати',
  addAnnouncement = 'Додати оголошення',
  showMore = 'Показати ще',
  deactivate = 'Деактивувати',
  activate = 'Активувати',
  edit = 'Редагувати',
  save = 'Зберегти',
  back = 'Назад',
  publish = 'Опублікувати',
  no = 'Ні',
  yes = 'Так',
  changePassword = 'Змінити пароль',
  reloadPage = 'Оновити сторінку',
  goToMain = 'Перейти на головну',
}

export enum INPUT_LABELS {
  email = 'Електронна пошта',
  name = 'Імʼя',
  surname = 'Прізвище',
  address = 'Локація',
  password = 'Пароль',
  confirmPassword = 'Повторіть пароль',
  animalType = 'Вид тварини',
  location = 'Локація',
  price = 'Ціна',
  free = 'Безкоштовно',
  breed = 'Різновид',
  petOrigin = 'Походження тварини',
  age = 'Вік',
  sex = 'Стать',
  color = 'Забарвлення',
  summary = 'Додаткова інформація',
  title = 'Назва оголошення',
  min = 'Мін',
  max = 'Макс',
}

export enum PLACEHOLDERS {
  location = 'Оберіть локацію',
  price = 'Введіть ціну',
  title = 'Введіть назву оголошення',
  animalType = 'Оберіть вид тварини',
  age = 'Введіть вік',
  period = 'Період',
  breed = 'Оберіть різновид',
  sort = 'Сортувати за',
  chooseColor = 'Оберіть забарвлення',
  petOrigin = 'Оберіть походження',
  email = 'Введіть вашу пошту',
  password = 'Введіть пароль',
  confirmPassword = 'Повторіть пароль',
  name = 'Введіть імʼя',
  surname = 'Введіть прізвище',
  summary = 'Вкажіть особливості характеру, звички, потреби у догляді, або будь-яку іншу важливу інформацію про тварину',
  sex = 'Оберіть стать',
}

export const PERIOD_TYPE_LIST = [PERIOD_TYPES.DAYS, PERIOD_TYPES.WEEKS, PERIOD_TYPES.MONTHS, PERIOD_TYPES.YEARS];

export const enum PERIOD_TYPES {
  DAYS = 'Днів',
  WEEKS = 'Тижнів',
  MONTHS = 'Місяців',
  YEARS = 'Років',
}

export const GENDER_LIST = ['Дівчинка', 'Хлопчик', 'Невідомо'];

export const SORT_OPTIONS_LIST = ['Найновіші', 'Від дешевих до дорогих', 'Від дорогих до дешевих'];

export const ADD_PET_PET_ORIGIN_OPTIONS_LIST = [
  {
    value: 1,
    label: 'Я представник притулку',
  },
  {
    value: 2,
    label: 'Я власник розплідника',
  },
  {
    value: 3,
    label: 'Я приватна особа',
  },
];

export enum AD_FORM_CONTROL_NAME {
  health = 'health',
  documents = 'documents',
}

export enum TOASTER_TYPE {
  ERROR = 'error',
  WARNING = 'warning',
  SUCCESS = 'success',
}

export enum TOASTER_MESSAGE {
  UNAUTHENTICATED = 'Для того щоб створити оголошення ввійдіть або зареєструйтеся',
  SERVER_ERROR = 'Вибачте, у нас виникла проблема з сервером, ми вже працюємо над цим',
  DATA_SAVED = 'Ваші введені дані збережені',
  SESSION_EXPIRED = 'Ваша сесія закінчилася, будь ласка, увійдіть знову',
  UNCOMPLETED_USER = 'Щоб додати оголошення, будь ласка, заповніть дані про себе',
}

export const enum ENDPOINT {
  // .NET
  DICTIONARY = 'property-definitions',
  PROPOSALS = 'proposals',

  // PYTHON
  SIGN_UP = 'v1/auth/register',
  SIGN_IN = 'v1/auth/login',
  ME = 'v1/users/me',
  FORGOT_PASSWORD = 'v1/auth/forgot-password',
  RESET_PASSWORD = 'v1/auth/reset-password',
}

export const enum SEARCH_NAMES {
  animalType = 'Вид тварини',
  breed = 'Різновид',
  sex = 'Стать',
}

export const enum STORAGE_KEYS {
  USER = 'USER',
  TOKEN = 'TOKEN',
}

export const enum SORT_OPTIONS {
  newest = 'Найновіші',
  fromCheap = 'Від дешевих до дорогих',
  fromExpensive = 'Від дорогих до дешевих',
}
