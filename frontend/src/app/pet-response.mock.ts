import { ProposalResponse } from './app.model';

const PET_RESPONSE_MOCK = {
  "items": [
    {
      "id": 172,
      "createdOn": "2024-09-24T01:58:20.145311",
      "lastModifiedOn": "2024-09-29T11:06:58.631075",
      "isActive": true,
      "petOrigin": 3,
      "title": "Домашній улюбленець",
      "price": 300,
      "summary": "Трошки гризе дроти і меблі",
      "location": "Бабина",
      "age": 330,
      "ageUnits": 30,
      "photos": [
        {
          "id": 40,
          "url": "https://stitmarathonprod.blob.core.windows.net/pet-images/a0a5f4ee-22d1-482a-a445-778d9df7af13.jpg"
        }
      ],
      "properties": [
        {
          "id": 3246,
          "propertyDefinition": {
            "id": 1,
            "name": "Вид тварини",
            "propertyDefinitionType": 0,
            "isMandatory": true,
            "propertyValues": []
          },
          "predefinedValue": {
            "id": 3,
            "value": "Гризуни"
          }
        },
        {
          "id": 3247,
          "propertyDefinition": {
            "id": 2,
            "name": "Різновид",
            "propertyDefinitionType": 0,
            "isMandatory": true,
            "propertyValues": []
          },
          "predefinedValue": {
            "id": 91,
            "value": "Песець",
            "parentPropertyValue": {
              "id": 3,
              "value": "Гризуни"
            }
          }
        },
        {
          "id": 3248,
          "propertyDefinition": {
            "id": 3,
            "name": "Стать",
            "propertyDefinitionType": 0,
            "isMandatory": true,
            "propertyValues": []
          },
          "predefinedValue": {
            "id": 9,
            "value": "Дівчинка"
          }
        },
        {
          "id": 3249,
          "propertyDefinition": {
            "id": 5,
            "name": "Забарвлення",
            "propertyDefinitionType": 0,
            "isMandatory": false,
            "propertyValues": []
          },
          "predefinedValue": {
            "id": 15,
            "value": "Кремове"
          }
        },
        {
          "id": 3250,
          "customValue": "customValue",
          "propertyDefinition": {
            "id": 7,
            "name": "Вакцинація",
            "propertyDefinitionType": 1,
            "isMandatory": false,
            "category": "Health",
            "propertyValues": []
          }
        },
        {
          "id": 3251,
          "customValue": "customValue",
          "propertyDefinition": {
            "id": 6,
            "name": "Стерилізація",
            "propertyDefinitionType": 1,
            "isMandatory": false,
            "category": "Health",
            "propertyValues": []
          }
        },
        {
          "id": 3252,
          "customValue": "customValue",
          "propertyDefinition": {
            "id": 8,
            "name": "Чіп",
            "propertyDefinitionType": 1,
            "isMandatory": false,
            "category": "Health",
            "propertyValues": []
          }
        },
        {
          "id": 3253,
          "customValue": "customValue",
          "propertyDefinition": {
            "id": 9,
            "name": "Обробка від паразитів",
            "propertyDefinitionType": 1,
            "isMandatory": false,
            "category": "Health",
            "propertyValues": []
          }
        },
        {
          "id": 3254,
          "customValue": "customValue",
          "propertyDefinition": {
            "id": 12,
            "name": "FCI/KCY",
            "propertyDefinitionType": 1,
            "isMandatory": false,
            "category": "Documents",
            "propertyValues": []
          }
        },
        {
          "id": 3255,
          "customValue": "customValue",
          "propertyDefinition": {
            "id": 13,
            "name": "Щеняча метрика",
            "propertyDefinitionType": 1,
            "isMandatory": false,
            "category": "Documents",
            "propertyValues": []
          }
        }
      ],
      "appUser": {
        "id": 10,
        "name": "Hen",
        "surname": "Sh",
        "email": "mail@gmail.com",
        "location": "Дніпро"
      }
    },
    {
      "id": 73,
      "createdOn": "2024-09-20T14:32:44.118988",
      "lastModifiedOn": "2024-09-22T20:42:39.819512",
      "isActive": true,
      "petOrigin": 3,
      "title": "Котик-муркотик",
      "price": 1500,
      "summary": "",
      "location": "Кричанівка",
      "age": 30,
      "ageUnits": 30,
      "photos": [
        {
          "id": 23,
          "url": "https://stitmarathonprod.blob.core.windows.net/pet-images/1de3ec5c-a2c7-4db5-a4de-b2a7bc600eaa.jpg"
        },
        {
          "id": 38,
          "url": "https://stitmarathonprod.blob.core.windows.net/pet-images/583cf4ad-a89e-4a59-883f-26b110ba8bce.jpg"
        }
      ],
      "properties": [
        {
          "id": 1072,
          "propertyDefinition": {
            "id": 1,
            "name": "Вид тварини",
            "propertyDefinitionType": 0,
            "isMandatory": true,
            "propertyValues": []
          },
          "predefinedValue": {
            "id": 2,
            "value": "Коти"
          }
        },
        {
          "id": 1073,
          "propertyDefinition": {
            "id": 2,
            "name": "Різновид",
            "propertyDefinitionType": 0,
            "isMandatory": true,
            "propertyValues": []
          },
          "predefinedValue": {
            "id": 48,
            "value": "Мейн-кун",
            "parentPropertyValue": {
              "id": 2,
              "value": "Коти"
            }
          }
        },
        {
          "id": 1074,
          "propertyDefinition": {
            "id": 3,
            "name": "Стать",
            "propertyDefinitionType": 0,
            "isMandatory": true,
            "propertyValues": []
          },
          "predefinedValue": {
            "id": 8,
            "value": "Хлопчик"
          }
        },
        {
          "id": 1075,
          "propertyDefinition": {
            "id": 5,
            "name": "Забарвлення",
            "propertyDefinitionType": 0,
            "isMandatory": false,
            "propertyValues": []
          },
          "predefinedValue": {
            "id": 20,
            "value": "Блакитне"
          }
        },
        {
          "id": 1076,
          "customValue": "customValue",
          "propertyDefinition": {
            "id": 7,
            "name": "Вакцинація",
            "propertyDefinitionType": 1,
            "isMandatory": false,
            "category": "Health",
            "propertyValues": []
          }
        },
        {
          "id": 1077,
          "customValue": "customValue",
          "propertyDefinition": {
            "id": 6,
            "name": "Стерилізація",
            "propertyDefinitionType": 1,
            "isMandatory": false,
            "category": "Health",
            "propertyValues": []
          }
        },
        {
          "id": 1078,
          "customValue": "customValue",
          "propertyDefinition": {
            "id": 13,
            "name": "Щеняча метрика",
            "propertyDefinitionType": 1,
            "isMandatory": false,
            "category": "Documents",
            "propertyValues": []
          }
        },
        {
          "id": 1079,
          "customValue": "customValue",
          "propertyDefinition": {
            "id": 12,
            "name": "FCI/KCY",
            "propertyDefinitionType": 1,
            "isMandatory": false,
            "category": "Documents",
            "propertyValues": []
          }
        },
        {
          "id": 1080,
          "customValue": "customValue",
          "propertyDefinition": {
            "id": 11,
            "name": "Родовід",
            "propertyDefinitionType": 1,
            "isMandatory": false,
            "category": "Documents",
            "propertyValues": []
          }
        }
      ],
      "appUser": {
        "id": 10,
        "name": "Hen",
        "surname": "Sh",
        "email": "mail@gmail.com",
        "location": "Дніпро"
      }
    },
    {
      "id": 71,
      "createdOn": "2024-09-19T15:34:26.577747",
      "isActive": true,
      "petOrigin": 3,
      "title": "Дуже добра собачка",
      "price": 5000,
      "summary": "Найдобріша собачку, яку я тільки бачив. Завжди посміхається на всі зубки (дивіться фото). Не хочу з нею розставатися, та дружина каже, що я люблю Елі (ім'я собачки) більше, ніж її.",
      "location": "Абрамівська Долина",
      "age": 2555,
      "ageUnits": 365,
      "photos": [
        {
          "id": 20,
          "url": "https://stitmarathonprod.blob.core.windows.net/pet-images/362daefc-647b-4b1d-a35a-7adad3d31732.jpg"
        },
        {
          "id": 21,
          "url": "https://stitmarathonprod.blob.core.windows.net/pet-images/64b2b10c-1665-47ea-90e2-a223c7fdb346.jpg"
        },
        {
          "id": 22,
          "url": "https://stitmarathonprod.blob.core.windows.net/pet-images/3ee565fe-e2f6-49a7-8601-bd2bbafe7501.jpg"
        }
      ],
      "properties": [
        {
          "id": 282,
          "propertyDefinition": {
            "id": 1,
            "name": "Вид тварини",
            "propertyDefinitionType": 0,
            "isMandatory": true,
            "propertyValues": []
          },
          "predefinedValue": {
            "id": 1,
            "value": "Собаки"
          }
        },
        {
          "id": 283,
          "propertyDefinition": {
            "id": 2,
            "name": "Різновид",
            "propertyDefinitionType": 0,
            "isMandatory": true,
            "propertyValues": []
          },
          "predefinedValue": {
            "id": 156,
            "value": "Інше",
            "parentPropertyValue": {
              "id": 1,
              "value": "Собаки"
            }
          }
        },
        {
          "id": 284,
          "propertyDefinition": {
            "id": 3,
            "name": "Стать",
            "propertyDefinitionType": 0,
            "isMandatory": true,
            "propertyValues": []
          },
          "predefinedValue": {
            "id": 9,
            "value": "Дівчинка"
          }
        },
        {
          "id": 285,
          "propertyDefinition": {
            "id": 5,
            "name": "Забарвлення",
            "propertyDefinitionType": 0,
            "isMandatory": false,
            "propertyValues": []
          },
          "predefinedValue": {
            "id": 12,
            "value": "Чорне"
          }
        },
        {
          "id": 286,
          "customValue": "customValue",
          "propertyDefinition": {
            "id": 8,
            "name": "Чіп",
            "propertyDefinitionType": 1,
            "isMandatory": false,
            "category": "Health",
            "propertyValues": []
          }
        }
      ],
      "appUser": {
        "id": 10,
        "name": "Hen",
        "surname": "Sh",
        "email": "mail@gmail.com",
        "location": "Дніпро"
      }
    },
    {
      "id": 70,
      "createdOn": "2024-09-18T21:54:01.857878",
      "lastModifiedOn": "2024-09-29T10:46:23.722769",
      "isActive": true,
      "petOrigin": 1,
      "title": "Лев",
      "price": 24,
      "summary": "Очі бездонні",
      "location": "Абрамівська Долина",
      "age": 243,
      "ageUnits": 30,
      "photos": [
        {
          "id": 19,
          "url": "https://stitmarathonprod.blob.core.windows.net/pet-images/ab8d4ec6-8f8d-4bfd-9e53-8489a40383e1.jpg"
        }
      ],
      "properties": [
        {
          "id": 3239,
          "propertyDefinition": {
            "id": 1,
            "name": "Вид тварини",
            "propertyDefinitionType": 0,
            "isMandatory": true,
            "propertyValues": []
          },
          "predefinedValue": {
            "id": 5,
            "value": "Птахи"
          }
        },
        {
          "id": 3240,
          "propertyDefinition": {
            "id": 2,
            "name": "Різновид",
            "propertyDefinitionType": 0,
            "isMandatory": true,
            "propertyValues": []
          },
          "predefinedValue": {
            "id": 116,
            "value": "Нерозлучники",
            "parentPropertyValue": {
              "id": 5,
              "value": "Птахи"
            }
          }
        },
        {
          "id": 3241,
          "propertyDefinition": {
            "id": 3,
            "name": "Стать",
            "propertyDefinitionType": 0,
            "isMandatory": true,
            "propertyValues": []
          },
          "predefinedValue": {
            "id": 8,
            "value": "Хлопчик"
          }
        },
        {
          "id": 3242,
          "propertyDefinition": {
            "id": 5,
            "name": "Забарвлення",
            "propertyDefinitionType": 0,
            "isMandatory": false,
            "propertyValues": []
          },
          "predefinedValue": {
            "id": 15,
            "value": "Кремове"
          }
        },
        {
          "id": 3243,
          "customValue": "customValue",
          "propertyDefinition": {
            "id": 6,
            "name": "Стерилізація",
            "propertyDefinitionType": 1,
            "isMandatory": false,
            "category": "Health",
            "propertyValues": []
          }
        },
        {
          "id": 3244,
          "customValue": "customValue",
          "propertyDefinition": {
            "id": 7,
            "name": "Вакцинація",
            "propertyDefinitionType": 1,
            "isMandatory": false,
            "category": "Health",
            "propertyValues": []
          }
        },
        {
          "id": 3245,
          "customValue": "customValue",
          "propertyDefinition": {
            "id": 11,
            "name": "Родовід",
            "propertyDefinitionType": 1,
            "isMandatory": false,
            "category": "Documents",
            "propertyValues": []
          }
        }
      ],
      "appUser": {
        "id": 10,
        "name": "Hen",
        "surname": "Sh",
        "email": "mail@gmail.com",
        "location": "Дніпро"
      }
    }
  ],
  "totalCount": 28
} as unknown as ProposalResponse;

export default PET_RESPONSE_MOCK;
