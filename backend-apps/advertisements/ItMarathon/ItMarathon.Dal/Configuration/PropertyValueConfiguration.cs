using ItMarathon.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace ItMarathon.Dal.Configuration;

[ExcludeFromCodeCoverage]
public class PropertyValueConfiguration : IEntityTypeConfiguration<PropertyValue>
{
    public void Configure(EntityTypeBuilder<PropertyValue> builder)
    {
        builder.HasOne(pv => pv.Property)
           .WithOne(p => p.PredefinedValue)
           .HasForeignKey<Property>(p => p.PredefinedValueId)
           .IsRequired(false)
           .OnDelete(DeleteBehavior.SetNull);

        builder.HasIndex(pv => pv.Value);

        builder.HasData(
            // Types
            new PropertyValue() { Id = 1, PropertyDefinitionId = 1, Value = "Собаки" },
            new PropertyValue() { Id = 2, PropertyDefinitionId = 1, Value = "Коти" },
            new PropertyValue() { Id = 3, PropertyDefinitionId = 1, Value = "Гризуни" },
            new PropertyValue() { Id = 4, PropertyDefinitionId = 1, Value = "Риби" },
            new PropertyValue() { Id = 5, PropertyDefinitionId = 1, Value = "Птахи" },
            new PropertyValue() { Id = 6, PropertyDefinitionId = 1, Value = "Рептилії" },
            new PropertyValue() { Id = 7, PropertyDefinitionId = 1, Value = "Інші" },

            // Genders
            new PropertyValue() { Id = 8, PropertyDefinitionId = 3, Value = "Хлопчик" },
            new PropertyValue() { Id = 9, PropertyDefinitionId = 3, Value = "Дівчинка" },
            new PropertyValue() { Id = 154, PropertyDefinitionId = 3, Value = "Невідомо", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },

            // Colors
            new PropertyValue() { Id = 10, PropertyDefinitionId = 5, Value = "Руде" },
            new PropertyValue() { Id = 11, PropertyDefinitionId = 5, Value = "Біле" },
            new PropertyValue() { Id = 12, PropertyDefinitionId = 5, Value = "Чорне" },
            new PropertyValue() { Id = 13, PropertyDefinitionId = 5, Value = "Сіре" },
            new PropertyValue() { Id = 14, PropertyDefinitionId = 5, Value = "Коричневе" },
            new PropertyValue() { Id = 15, PropertyDefinitionId = 5, Value = "Кремове" },
            new PropertyValue() { Id = 16, PropertyDefinitionId = 5, Value = "Палеве" },
            new PropertyValue() { Id = 17, PropertyDefinitionId = 5, Value = "Рудувато-коричневе" },
            new PropertyValue() { Id = 18, PropertyDefinitionId = 5, Value = "Золотисте" },
            new PropertyValue() { Id = 19, PropertyDefinitionId = 5, Value = "Срібне" },
            new PropertyValue() { Id = 20, PropertyDefinitionId = 5, Value = "Блакитне" },
            new PropertyValue() { Id = 21, PropertyDefinitionId = 5, Value = "Зелене" },
            new PropertyValue() { Id = 22, PropertyDefinitionId = 5, Value = "Жовте" },
            new PropertyValue() { Id = 23, PropertyDefinitionId = 5, Value = "Оранжеве" },
            new PropertyValue() { Id = 24, PropertyDefinitionId = 5, Value = "Рожеве" },
            new PropertyValue() { Id = 25, PropertyDefinitionId = 5, Value = "Фіолетове" },
            new PropertyValue() { Id = 155, PropertyDefinitionId = 5, Value = "Інше", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },

            // Breeds
            // dog breeds
            new PropertyValue() { Id = 26, PropertyDefinitionId = 2, ParentId = 1, Value = "Німецька вівчарка" },
            new PropertyValue() { Id = 27, PropertyDefinitionId = 2, ParentId = 1, Value = "Лабрадор-ретрівер" },
            new PropertyValue() { Id = 28, PropertyDefinitionId = 2, ParentId = 1, Value = "Йоркширський тер'єр" },
            new PropertyValue() { Id = 29, PropertyDefinitionId = 2, ParentId = 1, Value = "Мопс" },
            new PropertyValue() { Id = 30, PropertyDefinitionId = 2, ParentId = 1, Value = "Золотистий ретрівер" },
            new PropertyValue() { Id = 31, PropertyDefinitionId = 2, ParentId = 1, Value = "Французький бульдог" },
            new PropertyValue() { Id = 32, PropertyDefinitionId = 2, ParentId = 1, Value = "Бігль" },
            new PropertyValue() { Id = 33, PropertyDefinitionId = 2, ParentId = 1, Value = "Чихуахуа" },
            new PropertyValue() { Id = 34, PropertyDefinitionId = 2, ParentId = 1, Value = "Такса" },
            new PropertyValue() { Id = 35, PropertyDefinitionId = 2, ParentId = 1, Value = "Сибірський хаскі" },
            new PropertyValue() { Id = 36, PropertyDefinitionId = 2, ParentId = 1, Value = "Американський стаффордширський тер'єр" },
            new PropertyValue() { Id = 37, PropertyDefinitionId = 2, ParentId = 1, Value = "Кокер-спанієль" },
            new PropertyValue() { Id = 38, PropertyDefinitionId = 2, ParentId = 1, Value = "Джек-рассел-тер'єр" },
            new PropertyValue() { Id = 39, PropertyDefinitionId = 2, ParentId = 1, Value = "Ши-тцу" },
            new PropertyValue() { Id = 40, PropertyDefinitionId = 2, ParentId = 1, Value = "Вест-хайленд-уайт-тер'єр" },
            new PropertyValue() { Id = 41, PropertyDefinitionId = 2, ParentId = 1, Value = "Мальтійська болонка" },
            new PropertyValue() { Id = 42, PropertyDefinitionId = 2, ParentId = 1, Value = "Боксер" },
            new PropertyValue() { Id = 43, PropertyDefinitionId = 2, ParentId = 1, Value = "Доберман" },
            new PropertyValue() { Id = 44, PropertyDefinitionId = 2, ParentId = 1, Value = "Шарпей" },
            new PropertyValue() { Id = 45, PropertyDefinitionId = 2, ParentId = 1, Value = "Акіта-іну" },
            new PropertyValue() { Id = 156, PropertyDefinitionId = 2, ParentId = 1, Value = "Інше", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },

            // cat breeds 
            new PropertyValue() { Id = 46, PropertyDefinitionId = 2, ParentId = 2, Value = "Британська короткошерста" },
            new PropertyValue() { Id = 47, PropertyDefinitionId = 2, ParentId = 2, Value = "Шотландська висловуха" },
            new PropertyValue() { Id = 48, PropertyDefinitionId = 2, ParentId = 2, Value = "Мейн-кун" },
            new PropertyValue() { Id = 49, PropertyDefinitionId = 2, ParentId = 2, Value = "Сфінкс" },
            new PropertyValue() { Id = 50, PropertyDefinitionId = 2, ParentId = 2, Value = "Перська" },
            new PropertyValue() { Id = 51, PropertyDefinitionId = 2, ParentId = 2, Value = "Сіамська" },
            new PropertyValue() { Id = 52, PropertyDefinitionId = 2, ParentId = 2, Value = "Європейська короткошерста" },
            new PropertyValue() { Id = 53, PropertyDefinitionId = 2, ParentId = 2, Value = "Бенгальська" },
            new PropertyValue() { Id = 54, PropertyDefinitionId = 2, ParentId = 2, Value = "Регдолл" },
            new PropertyValue() { Id = 55, PropertyDefinitionId = 2, ParentId = 2, Value = "Турецька ангора" },
            new PropertyValue() { Id = 56, PropertyDefinitionId = 2, ParentId = 2, Value = "Американська короткошерста" },
            new PropertyValue() { Id = 57, PropertyDefinitionId = 2, ParentId = 2, Value = "Невська маскарадна" },
            new PropertyValue() { Id = 58, PropertyDefinitionId = 2, ParentId = 2, Value = "Норвезька лісова" },
            new PropertyValue() { Id = 59, PropertyDefinitionId = 2, ParentId = 2, Value = "Сомалійська" },
            new PropertyValue() { Id = 60, PropertyDefinitionId = 2, ParentId = 2, Value = "Абіссинська" },
            new PropertyValue() { Id = 61, PropertyDefinitionId = 2, ParentId = 2, Value = "Орієнтальна" },
            new PropertyValue() { Id = 62, PropertyDefinitionId = 2, ParentId = 2, Value = "Екзотична короткошерста" },
            new PropertyValue() { Id = 63, PropertyDefinitionId = 2, ParentId = 2, Value = "Девон-рекс" },
            new PropertyValue() { Id = 64, PropertyDefinitionId = 2, ParentId = 2, Value = "Саванна" },
            new PropertyValue() { Id = 65, PropertyDefinitionId = 2, ParentId = 2, Value = "Бомбейська" },
            new PropertyValue() { Id = 66, PropertyDefinitionId = 2, ParentId = 2, Value = "Тонкінська" },
            new PropertyValue() { Id = 157, PropertyDefinitionId = 2, ParentId = 2, Value = "Інше", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },

            // Rodents
            new PropertyValue() { Id = 83, PropertyDefinitionId = 2, ParentId = 3, Value = "Хом'як", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 84, PropertyDefinitionId = 2, ParentId = 3, Value = "Миша", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 85, PropertyDefinitionId = 2, ParentId = 3, Value = "Морська свинка", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 86, PropertyDefinitionId = 2, ParentId = 3, Value = "Шиншила", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 87, PropertyDefinitionId = 2, ParentId = 3, Value = "Щур", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 88, PropertyDefinitionId = 2, ParentId = 3, Value = "Кролик", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 89, PropertyDefinitionId = 2, ParentId = 3, Value = "Заєць", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 90, PropertyDefinitionId = 2, ParentId = 3, Value = "Капібара", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 91, PropertyDefinitionId = 2, ParentId = 3, Value = "Песець", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 92, PropertyDefinitionId = 2, ParentId = 3, Value = "Білка", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 158, PropertyDefinitionId = 2, ParentId = 3, Value = "Інше", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },

            // Fish
            new PropertyValue() { Id = 93, PropertyDefinitionId = 2, ParentId = 4, Value = "Золота рибка", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 94, PropertyDefinitionId = 2, ParentId = 4, Value = "Гупі", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 95, PropertyDefinitionId = 2, ParentId = 4, Value = "Тернеція", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 96, PropertyDefinitionId = 2, ParentId = 4, Value = "Скалярія", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 97, PropertyDefinitionId = 2, ParentId = 4, Value = "Молінезія", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 98, PropertyDefinitionId = 2, ParentId = 4, Value = "Сом-панда", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 99, PropertyDefinitionId = 2, ParentId = 4, Value = "Барбус", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 100, PropertyDefinitionId = 2, ParentId = 4, Value = "Ампулярія", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 101, PropertyDefinitionId = 2, ParentId = 4, Value = "Коридорас", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 102, PropertyDefinitionId = 2, ParentId = 4, Value = "Торакатум", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 103, PropertyDefinitionId = 2, ParentId = 4, Value = "Пецилія", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 104, PropertyDefinitionId = 2, ParentId = 4, Value = "Тетра", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 105, PropertyDefinitionId = 2, ParentId = 4, Value = "Неон", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 106, PropertyDefinitionId = 2, ParentId = 4, Value = "Мечоносець", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 107, PropertyDefinitionId = 2, ParentId = 4, Value = "Лабео", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 108, PropertyDefinitionId = 2, ParentId = 4, Value = "Рамірезі", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 109, PropertyDefinitionId = 2, ParentId = 4, Value = "Даніо", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 110, PropertyDefinitionId = 2, ParentId = 4, Value = "Морський коник", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 159, PropertyDefinitionId = 2, ParentId = 4, Value = "Інше", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },

            // Birds
            new PropertyValue() { Id = 111, PropertyDefinitionId = 2, ParentId = 5, Value = "Хвилястий папуга", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 112, PropertyDefinitionId = 2, ParentId = 5, Value = "Корелла", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 113, PropertyDefinitionId = 2, ParentId = 5, Value = "Жако", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 114, PropertyDefinitionId = 2, ParentId = 5, Value = "Какаду", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 115, PropertyDefinitionId = 2, ParentId = 5, Value = "Амадін", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 116, PropertyDefinitionId = 2, ParentId = 5, Value = "Нерозлучники", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 117, PropertyDefinitionId = 2, ParentId = 5, Value = "Ара", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 118, PropertyDefinitionId = 2, ParentId = 5, Value = "Лорікет", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 119, PropertyDefinitionId = 2, ParentId = 5, Value = "Канарка", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 120, PropertyDefinitionId = 2, ParentId = 5, Value = "Голуб", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 121, PropertyDefinitionId = 2, ParentId = 5, Value = "Павлін", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 122, PropertyDefinitionId = 2, ParentId = 5, Value = "Фазан", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 123, PropertyDefinitionId = 2, ParentId = 5, Value = "Індик", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 124, PropertyDefinitionId = 2, ParentId = 5, Value = "Перепілка", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 125, PropertyDefinitionId = 2, ParentId = 5, Value = "Качка", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 126, PropertyDefinitionId = 2, ParentId = 5, Value = "Гуска", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 127, PropertyDefinitionId = 2, ParentId = 5, Value = "Півень", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 128, PropertyDefinitionId = 2, ParentId = 5, Value = "Курка", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 129, PropertyDefinitionId = 2, ParentId = 5, Value = "Пелікан", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 130, PropertyDefinitionId = 2, ParentId = 5, Value = "Страус", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 160, PropertyDefinitionId = 2, ParentId = 5, Value = "Інше", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },

            // Reptiles 
            new PropertyValue() { Id = 131, PropertyDefinitionId = 2, ParentId = 6, Value = "Ящірка", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 132, PropertyDefinitionId = 2, ParentId = 6, Value = "Гекон", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 133, PropertyDefinitionId = 2, ParentId = 6, Value = "Ігуана", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 134, PropertyDefinitionId = 2, ParentId = 6, Value = "Змія", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 135, PropertyDefinitionId = 2, ParentId = 6, Value = "Сухопутна черепаха", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 136, PropertyDefinitionId = 2, ParentId = 6, Value = "Морська черепаха", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 137, PropertyDefinitionId = 2, ParentId = 6, Value = "Водна черепаха", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 138, PropertyDefinitionId = 2, ParentId = 6, Value = "Хамелеон", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 161, PropertyDefinitionId = 2, ParentId = 6, Value = "Інше", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },

            // Other
            new PropertyValue() { Id = 139, PropertyDefinitionId = 2, ParentId = 7, Value = "Тритон", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 140, PropertyDefinitionId = 2, ParentId = 7, Value = "Павук", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 141, PropertyDefinitionId = 2, ParentId = 7, Value = "Лемур", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 142, PropertyDefinitionId = 2, ParentId = 7, Value = "Скорпіон", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 143, PropertyDefinitionId = 2, ParentId = 7, Value = "Саламандра", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 144, PropertyDefinitionId = 2, ParentId = 7, Value = "Єнот", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 145, PropertyDefinitionId = 2, ParentId = 7, Value = "Альпака", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 146, PropertyDefinitionId = 2, ParentId = 7, Value = "Кінь", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 147, PropertyDefinitionId = 2, ParentId = 7, Value = "Лама", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 148, PropertyDefinitionId = 2, ParentId = 7, Value = "Дикобраз", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 149, PropertyDefinitionId = 2, ParentId = 7, Value = "Їжак", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 150, PropertyDefinitionId = 2, ParentId = 7, Value = "Осел", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 151, PropertyDefinitionId = 2, ParentId = 7, Value = "Коза", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 152, PropertyDefinitionId = 2, ParentId = 7, Value = "Корова", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 153, PropertyDefinitionId = 2, ParentId = 7, Value = "Свиня", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) },
            new PropertyValue() { Id = 162, PropertyDefinitionId = 2, ParentId = 7, Value = "Інше", CreatedOn = new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc) }
        );
    }
}
