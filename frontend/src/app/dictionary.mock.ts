const DICTIONARY_MOCK = [
  {
    "id": 1,
    "name": "Вид тварини",
    "propertyDefinitionType": 0,
    "isMandatory": true,
    "propertyValues": [
      {
        "id": 1,
        "value": "Собаки"
      },
      {
        "id": 2,
        "value": "Коти"
      },
      {
        "id": 3,
        "value": "Гризуни"
      },
      {
        "id": 4,
        "value": "Риби"
      },
      {
        "id": 5,
        "value": "Птахи"
      },
      {
        "id": 6,
        "value": "Рептилії"
      },
      {
        "id": 7,
        "value": "Інші"
      }
    ]
  },
  {
    "id": 2,
    "name": "Різновид",
    "propertyDefinitionType": 0,
    "isMandatory": true,
    "propertyValues": [
      {
        "id": 26,
        "value": "Німецька вівчарка",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 27,
        "value": "Лабрадор-ретрівер",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 28,
        "value": "Йоркширський тер'єр",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 29,
        "value": "Мопс",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 30,
        "value": "Золотистий ретрівер",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 31,
        "value": "Французький бульдог",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 32,
        "value": "Бігль",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 33,
        "value": "Чихуахуа",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 34,
        "value": "Такса",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 35,
        "value": "Сибірський хаскі",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 36,
        "value": "Американський стаффордширський тер'єр",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 37,
        "value": "Кокер-спанієль",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 38,
        "value": "Джек-рассел-тер'єр",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 39,
        "value": "Ши-тцу",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 40,
        "value": "Вест-хайленд-уайт-тер'єр",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 41,
        "value": "Мальтійська болонка",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 42,
        "value": "Боксер",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 43,
        "value": "Доберман",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 44,
        "value": "Шарпей",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 45,
        "value": "Акіта-іну",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 46,
        "value": "Британська короткошерста",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 47,
        "value": "Шотландська висловуха",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 48,
        "value": "Мейн-кун",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 49,
        "value": "Сфінкс",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 50,
        "value": "Перська",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 51,
        "value": "Сіамська",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 52,
        "value": "Європейська короткошерста",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 53,
        "value": "Бенгальська",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 54,
        "value": "Регдолл",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 55,
        "value": "Турецька ангора",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 56,
        "value": "Американська короткошерста",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 57,
        "value": "Невська маскарадна",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 58,
        "value": "Норвезька лісова",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 59,
        "value": "Сомалійська",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 60,
        "value": "Абіссинська",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 61,
        "value": "Орієнтальна",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 62,
        "value": "Екзотична короткошерста",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 63,
        "value": "Девон-рекс",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 64,
        "value": "Саванна",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 65,
        "value": "Бомбейська",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 66,
        "value": "Тонкінська",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 83,
        "value": "Хом'як",
        "parentPropertyValue": {
          "id": 3,
          "value": "Гризуни"
        }
      },
      {
        "id": 84,
        "value": "Миша",
        "parentPropertyValue": {
          "id": 3,
          "value": "Гризуни"
        }
      },
      {
        "id": 85,
        "value": "Морська свинка",
        "parentPropertyValue": {
          "id": 3,
          "value": "Гризуни"
        }
      },
      {
        "id": 86,
        "value": "Шиншила",
        "parentPropertyValue": {
          "id": 3,
          "value": "Гризуни"
        }
      },
      {
        "id": 87,
        "value": "Щур",
        "parentPropertyValue": {
          "id": 3,
          "value": "Гризуни"
        }
      },
      {
        "id": 88,
        "value": "Кролик",
        "parentPropertyValue": {
          "id": 3,
          "value": "Гризуни"
        }
      },
      {
        "id": 89,
        "value": "Заєць",
        "parentPropertyValue": {
          "id": 3,
          "value": "Гризуни"
        }
      },
      {
        "id": 90,
        "value": "Капібара",
        "parentPropertyValue": {
          "id": 3,
          "value": "Гризуни"
        }
      },
      {
        "id": 91,
        "value": "Песець",
        "parentPropertyValue": {
          "id": 3,
          "value": "Гризуни"
        }
      },
      {
        "id": 92,
        "value": "Білка",
        "parentPropertyValue": {
          "id": 3,
          "value": "Гризуни"
        }
      },
      {
        "id": 93,
        "value": "Золота рибка",
        "parentPropertyValue": {
          "id": 4,
          "value": "Риби"
        }
      },
      {
        "id": 94,
        "value": "Гупі",
        "parentPropertyValue": {
          "id": 4,
          "value": "Риби"
        }
      },
      {
        "id": 95,
        "value": "Тернеція",
        "parentPropertyValue": {
          "id": 4,
          "value": "Риби"
        }
      },
      {
        "id": 96,
        "value": "Скалярія",
        "parentPropertyValue": {
          "id": 4,
          "value": "Риби"
        }
      },
      {
        "id": 97,
        "value": "Молінезія",
        "parentPropertyValue": {
          "id": 4,
          "value": "Риби"
        }
      },
      {
        "id": 98,
        "value": "Сом-панда",
        "parentPropertyValue": {
          "id": 4,
          "value": "Риби"
        }
      },
      {
        "id": 99,
        "value": "Барбус",
        "parentPropertyValue": {
          "id": 4,
          "value": "Риби"
        }
      },
      {
        "id": 100,
        "value": "Ампулярія",
        "parentPropertyValue": {
          "id": 4,
          "value": "Риби"
        }
      },
      {
        "id": 101,
        "value": "Коридорас",
        "parentPropertyValue": {
          "id": 4,
          "value": "Риби"
        }
      },
      {
        "id": 102,
        "value": "Торакатум",
        "parentPropertyValue": {
          "id": 4,
          "value": "Риби"
        }
      },
      {
        "id": 103,
        "value": "Пецилія",
        "parentPropertyValue": {
          "id": 4,
          "value": "Риби"
        }
      },
      {
        "id": 104,
        "value": "Тетра",
        "parentPropertyValue": {
          "id": 4,
          "value": "Риби"
        }
      },
      {
        "id": 105,
        "value": "Неон",
        "parentPropertyValue": {
          "id": 4,
          "value": "Риби"
        }
      },
      {
        "id": 106,
        "value": "Мечоносець",
        "parentPropertyValue": {
          "id": 4,
          "value": "Риби"
        }
      },
      {
        "id": 107,
        "value": "Лабео",
        "parentPropertyValue": {
          "id": 4,
          "value": "Риби"
        }
      },
      {
        "id": 108,
        "value": "Рамірезі",
        "parentPropertyValue": {
          "id": 4,
          "value": "Риби"
        }
      },
      {
        "id": 109,
        "value": "Даніо",
        "parentPropertyValue": {
          "id": 4,
          "value": "Риби"
        }
      },
      {
        "id": 110,
        "value": "Морський коник",
        "parentPropertyValue": {
          "id": 4,
          "value": "Риби"
        }
      },
      {
        "id": 111,
        "value": "Хвилястий папуга",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 112,
        "value": "Корелла",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 113,
        "value": "Жако",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 114,
        "value": "Какаду",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 115,
        "value": "Амадін",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 116,
        "value": "Нерозлучники",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 117,
        "value": "Ара",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 118,
        "value": "Лорікет",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 119,
        "value": "Канарка",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 120,
        "value": "Голуб",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 121,
        "value": "Павлін",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 122,
        "value": "Фазан",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 123,
        "value": "Індик",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 124,
        "value": "Перепілка",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 125,
        "value": "Качка",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 126,
        "value": "Гуска",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 127,
        "value": "Півень",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 128,
        "value": "Курка",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 129,
        "value": "Пелікан",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 130,
        "value": "Страус",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 131,
        "value": "Ящірка",
        "parentPropertyValue": {
          "id": 6,
          "value": "Рептилії"
        }
      },
      {
        "id": 132,
        "value": "Гекон",
        "parentPropertyValue": {
          "id": 6,
          "value": "Рептилії"
        }
      },
      {
        "id": 133,
        "value": "Ігуана",
        "parentPropertyValue": {
          "id": 6,
          "value": "Рептилії"
        }
      },
      {
        "id": 134,
        "value": "Змія",
        "parentPropertyValue": {
          "id": 6,
          "value": "Рептилії"
        }
      },
      {
        "id": 135,
        "value": "Сухопутна черепаха",
        "parentPropertyValue": {
          "id": 6,
          "value": "Рептилії"
        }
      },
      {
        "id": 136,
        "value": "Морська черепаха",
        "parentPropertyValue": {
          "id": 6,
          "value": "Рептилії"
        }
      },
      {
        "id": 137,
        "value": "Водна черепаха",
        "parentPropertyValue": {
          "id": 6,
          "value": "Рептилії"
        }
      },
      {
        "id": 138,
        "value": "Хамелеон",
        "parentPropertyValue": {
          "id": 6,
          "value": "Рептилії"
        }
      },
      {
        "id": 139,
        "value": "Тритон",
        "parentPropertyValue": {
          "id": 7,
          "value": "Інші"
        }
      },
      {
        "id": 140,
        "value": "Павук",
        "parentPropertyValue": {
          "id": 7,
          "value": "Інші"
        }
      },
      {
        "id": 141,
        "value": "Лемур",
        "parentPropertyValue": {
          "id": 7,
          "value": "Інші"
        }
      },
      {
        "id": 142,
        "value": "Скорпіон",
        "parentPropertyValue": {
          "id": 7,
          "value": "Інші"
        }
      },
      {
        "id": 143,
        "value": "Саламандра",
        "parentPropertyValue": {
          "id": 7,
          "value": "Інші"
        }
      },
      {
        "id": 144,
        "value": "Єнот",
        "parentPropertyValue": {
          "id": 7,
          "value": "Інші"
        }
      },
      {
        "id": 145,
        "value": "Альпака",
        "parentPropertyValue": {
          "id": 7,
          "value": "Інші"
        }
      },
      {
        "id": 146,
        "value": "Кінь",
        "parentPropertyValue": {
          "id": 7,
          "value": "Інші"
        }
      },
      {
        "id": 147,
        "value": "Лама",
        "parentPropertyValue": {
          "id": 7,
          "value": "Інші"
        }
      },
      {
        "id": 148,
        "value": "Дикобраз",
        "parentPropertyValue": {
          "id": 7,
          "value": "Інші"
        }
      },
      {
        "id": 149,
        "value": "Їжак",
        "parentPropertyValue": {
          "id": 7,
          "value": "Інші"
        }
      },
      {
        "id": 150,
        "value": "Осел",
        "parentPropertyValue": {
          "id": 7,
          "value": "Інші"
        }
      },
      {
        "id": 151,
        "value": "Коза",
        "parentPropertyValue": {
          "id": 7,
          "value": "Інші"
        }
      },
      {
        "id": 152,
        "value": "Корова",
        "parentPropertyValue": {
          "id": 7,
          "value": "Інші"
        }
      },
      {
        "id": 153,
        "value": "Свиня",
        "parentPropertyValue": {
          "id": 7,
          "value": "Інші"
        }
      },
      {
        "id": 156,
        "value": "Інше",
        "parentPropertyValue": {
          "id": 1,
          "value": "Собаки"
        }
      },
      {
        "id": 157,
        "value": "Інше",
        "parentPropertyValue": {
          "id": 2,
          "value": "Коти"
        }
      },
      {
        "id": 158,
        "value": "Інше",
        "parentPropertyValue": {
          "id": 3,
          "value": "Гризуни"
        }
      },
      {
        "id": 159,
        "value": "Інше",
        "parentPropertyValue": {
          "id": 4,
          "value": "Риби"
        }
      },
      {
        "id": 160,
        "value": "Інше",
        "parentPropertyValue": {
          "id": 5,
          "value": "Птахи"
        }
      },
      {
        "id": 161,
        "value": "Інше",
        "parentPropertyValue": {
          "id": 6,
          "value": "Рептилії"
        }
      },
      {
        "id": 162,
        "value": "Інше",
        "parentPropertyValue": {
          "id": 7,
          "value": "Інші"
        }
      }
    ]
  },
  {
    "id": 3,
    "name": "Стать",
    "propertyDefinitionType": 0,
    "isMandatory": true,
    "propertyValues": [
      {
        "id": 8,
        "value": "Хлопчик"
      },
      {
        "id": 9,
        "value": "Дівчинка"
      },
      {
        "id": 154,
        "value": "Невідомо"
      }
    ]
  },
  {
    "id": 5,
    "name": "Забарвлення",
    "propertyDefinitionType": 0,
    "isMandatory": false,
    "propertyValues": [
      {
        "id": 10,
        "value": "Руде"
      },
      {
        "id": 11,
        "value": "Біле"
      },
      {
        "id": 12,
        "value": "Чорне"
      },
      {
        "id": 13,
        "value": "Сіре"
      },
      {
        "id": 14,
        "value": "Коричневе"
      },
      {
        "id": 15,
        "value": "Кремове"
      },
      {
        "id": 16,
        "value": "Палеве"
      },
      {
        "id": 17,
        "value": "Рудувато-коричневе"
      },
      {
        "id": 18,
        "value": "Золотисте"
      },
      {
        "id": 19,
        "value": "Срібне"
      },
      {
        "id": 20,
        "value": "Блакитне"
      },
      {
        "id": 21,
        "value": "Зелене"
      },
      {
        "id": 22,
        "value": "Жовте"
      },
      {
        "id": 23,
        "value": "Оранжеве"
      },
      {
        "id": 24,
        "value": "Рожеве"
      },
      {
        "id": 25,
        "value": "Фіолетове"
      },
      {
        "id": 155,
        "value": "Інше"
      }
    ]
  },
  {
    "id": 6,
    "name": "Стерилізація",
    "propertyDefinitionType": 1,
    "isMandatory": false,
    "category": "Health",
    "propertyValues": []
  },
  {
    "id": 7,
    "name": "Вакцинація",
    "propertyDefinitionType": 1,
    "isMandatory": false,
    "category": "Health",
    "propertyValues": []
  },
  {
    "id": 8,
    "name": "Чіп",
    "propertyDefinitionType": 1,
    "isMandatory": false,
    "category": "Health",
    "propertyValues": []
  },
  {
    "id": 9,
    "name": "Обробка від паразитів",
    "propertyDefinitionType": 1,
    "isMandatory": false,
    "category": "Health",
    "propertyValues": []
  },
  {
    "id": 10,
    "name": "Ветпаспорт",
    "propertyDefinitionType": 1,
    "isMandatory": false,
    "category": "Documents",
    "propertyValues": []
  },
  {
    "id": 11,
    "name": "Родовід",
    "propertyDefinitionType": 1,
    "isMandatory": false,
    "category": "Documents",
    "propertyValues": []
  },
  {
    "id": 12,
    "name": "FCI/KCY",
    "propertyDefinitionType": 1,
    "isMandatory": false,
    "category": "Documents",
    "propertyValues": []
  },
  {
    "id": 13,
    "name": "Щеняча метрика",
    "propertyDefinitionType": 1,
    "isMandatory": false,
    "category": "Documents",
    "propertyValues": []
  }
];

export default DICTIONARY_MOCK;
