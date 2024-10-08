using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ItMarathon.Dal.Migrations;

/// <inheritdoc />
public partial class SeedPropertyValues : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 2L,
            column: "Name",
            value: "Різновид");

        migrationBuilder.InsertData(
            table: "PropertyValues",
            columns: new[] { "Id", "CreatedOn", "LastModifiedOn", "ParentId", "PropertyDefinitionId", "Value" },
            values: new object[,]
            {
                { 83L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(7914), null, 3L, 2L, "Хом'як" },
                { 84L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(7917), null, 3L, 2L, "Миша" },
                { 85L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(7918), null, 3L, 2L, "Морська свинка" },
                { 86L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(7919), null, 3L, 2L, "Шиншила" },
                { 87L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(7920), null, 3L, 2L, "Щур" },
                { 88L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(7921), null, 3L, 2L, "Кролик" },
                { 89L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(7922), null, 3L, 2L, "Заєць" },
                { 90L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(7923), null, 3L, 2L, "Капібара" },
                { 91L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(7924), null, 3L, 2L, "Песець" },
                { 92L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(7948), null, 3L, 2L, "Білка" },
                { 93L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(7949), null, 4L, 2L, "Золота рибка" },
                { 94L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(7950), null, 4L, 2L, "Гупі" },
                { 95L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(7951), null, 4L, 2L, "Тернеція" },
                { 96L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(7996), null, 4L, 2L, "Скалярія" },
                { 97L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(7998), null, 4L, 2L, "Молінезія" },
                { 98L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(7999), null, 4L, 2L, "Сом-панда" },
                { 99L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8000), null, 4L, 2L, "Барбус" },
                { 100L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8001), null, 4L, 2L, "Ампулярія" },
                { 101L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8002), null, 4L, 2L, "Коридорас" },
                { 102L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8003), null, 4L, 2L, "Торакатум" },
                { 103L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8004), null, 4L, 2L, "Пецилія" },
                { 104L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8005), null, 4L, 2L, "Тетра" },
                { 105L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8006), null, 4L, 2L, "Неон" },
                { 106L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8007), null, 4L, 2L, "Мечоносець" },
                { 107L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8008), null, 4L, 2L, "Лабео" },
                { 108L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8009), null, 4L, 2L, "Рамірезі" },
                { 109L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8010), null, 4L, 2L, "Даніо" },
                { 110L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8012), null, 4L, 2L, "Морський коник" },
                { 111L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8013), null, 5L, 2L, "Хвилястий папуга" },
                { 112L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8014), null, 5L, 2L, "Корелла" },
                { 113L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8015), null, 5L, 2L, "Жако" },
                { 114L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8016), null, 5L, 2L, "Какаду" },
                { 115L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8017), null, 5L, 2L, "Амадін" },
                { 116L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8018), null, 5L, 2L, "Нерозлучники" },
                { 117L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8019), null, 5L, 2L, "Ара" },
                { 118L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8021), null, 5L, 2L, "Лорікет" },
                { 119L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8022), null, 5L, 2L, "Канарка" },
                { 120L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8023), null, 5L, 2L, "Голуб" },
                { 121L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8024), null, 5L, 2L, "Павлін" },
                { 122L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8025), null, 5L, 2L, "Фазан" },
                { 123L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8026), null, 5L, 2L, "Індик" },
                { 124L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8027), null, 5L, 2L, "Перепілка" },
                { 125L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8028), null, 5L, 2L, "Качка" },
                { 126L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8030), null, 5L, 2L, "Гуска" },
                { 127L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8031), null, 5L, 2L, "Півень" },
                { 128L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8032), null, 5L, 2L, "Курка" },
                { 129L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8033), null, 5L, 2L, "Пелікан" },
                { 130L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8034), null, 5L, 2L, "Страус" },
                { 131L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8035), null, 6L, 2L, "Ящірка" },
                { 132L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8039), null, 6L, 2L, "Гекон" },
                { 133L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8040), null, 6L, 2L, "Ігуана" },
                { 134L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8041), null, 6L, 2L, "Змія" },
                { 135L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8042), null, 6L, 2L, "Сухопутна черепаха" },
                { 136L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8043), null, 6L, 2L, "Морська черепаха" },
                { 137L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8044), null, 6L, 2L, "Водна черепаха" },
                { 138L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8045), null, 6L, 2L, "Хамелеон" },
                { 139L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8046), null, 7L, 2L, "Тритон" },
                { 140L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8047), null, 7L, 2L, "Павук" },
                { 141L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8048), null, 7L, 2L, "Лемур" },
                { 142L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8050), null, 7L, 2L, "Скорпіон" },
                { 143L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8051), null, 7L, 2L, "Саламандра" },
                { 144L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8052), null, 7L, 2L, "Єнот" },
                { 145L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8053), null, 7L, 2L, "Альпака" },
                { 146L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8054), null, 7L, 2L, "Кінь" },
                { 147L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8055), null, 7L, 2L, "Лама" },
                { 148L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8056), null, 7L, 2L, "Дикобраз" },
                { 149L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8057), null, 7L, 2L, "Їжак" },
                { 150L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8058), null, 7L, 2L, "Осел" },
                { 151L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8059), null, 7L, 2L, "Коза" },
                { 152L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8060), null, 7L, 2L, "Корова" },
                { 153L, new DateTime(2024, 8, 12, 13, 37, 44, 983, DateTimeKind.Utc).AddTicks(8061), null, 7L, 2L, "Свиня" }
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 83L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 84L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 85L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 86L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 87L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 88L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 89L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 90L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 91L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 92L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 93L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 94L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 95L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 96L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 97L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 98L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 99L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 100L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 101L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 102L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 103L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 104L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 105L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 106L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 107L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 108L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 109L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 110L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 111L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 112L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 113L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 114L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 115L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 116L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 117L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 118L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 119L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 120L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 121L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 122L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 123L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 124L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 125L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 126L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 127L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 128L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 129L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 130L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 131L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 132L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 133L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 134L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 135L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 136L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 137L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 138L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 139L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 140L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 141L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 142L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 143L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 144L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 145L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 146L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 147L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 148L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 149L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 150L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 151L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 152L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 153L);

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 2L,
            column: "Name",
            value: "Порода");
    }
}
