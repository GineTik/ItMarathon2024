using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ItMarathon.Dal.Migrations;

/// <inheritdoc />
public partial class SeedAdditionalPropertyData : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<bool>(
            name: "IsActive",
            table: "Proposals",
            type: "tinyint(1)",
            nullable: false,
            defaultValue: false);

        migrationBuilder.AddColumn<int>(
            name: "PetOrigin",
            table: "Proposals",
            type: "int",
            nullable: false,
            defaultValue: 0);

        migrationBuilder.AddColumn<long>(
            name: "ParentId",
            table: "PropertyValues",
            type: "bigint",
            nullable: true);

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 1L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7075));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 2L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7122));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 3L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7124));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 4L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7126));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 5L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7128));

        migrationBuilder.InsertData(
            table: "PropertiesDefinition",
            columns: new[] { "Id", "CreatedOn", "IsMandatory", "LastModifiedOn", "Name", "PropertyDefinitionType" },
            values: new object[,]
            {
                { 6L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7130), true, null, "Стерилізація", 0 },
                { 7L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7132), true, null, "Вакцинація", 0 },
                { 8L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7134), false, null, "Чіп", 0 },
                { 9L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7136), false, null, "Обробка від паразитів", 0 },
                { 10L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7138), false, null, "Ветпаспорт", 0 },
                { 11L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7140), false, null, "Родовід", 0 },
                { 12L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7142), false, null, "FCI/KCY", 0 },
                { 13L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7144), false, null, "Щеняча метрика", 0 }
            });

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 1L,
            columns: new[] { "CreatedOn", "ParentId" },
            values: new object[] { new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8750), null });

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 2L,
            columns: new[] { "CreatedOn", "ParentId" },
            values: new object[] { new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8763), null });

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 3L,
            columns: new[] { "CreatedOn", "ParentId" },
            values: new object[] { new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8765), null });

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 4L,
            columns: new[] { "CreatedOn", "ParentId" },
            values: new object[] { new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8767), null });

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 5L,
            columns: new[] { "CreatedOn", "ParentId" },
            values: new object[] { new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8769), null });

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 6L,
            columns: new[] { "CreatedOn", "ParentId" },
            values: new object[] { new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8771), null });

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 7L,
            columns: new[] { "CreatedOn", "ParentId" },
            values: new object[] { new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8773), null });

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 8L,
            columns: new[] { "CreatedOn", "ParentId" },
            values: new object[] { new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8799), null });

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 9L,
            columns: new[] { "CreatedOn", "ParentId" },
            values: new object[] { new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8802), null });

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 10L,
            columns: new[] { "CreatedOn", "ParentId" },
            values: new object[] { new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8804), null });

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 11L,
            columns: new[] { "CreatedOn", "ParentId" },
            values: new object[] { new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8806), null });

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 12L,
            columns: new[] { "CreatedOn", "ParentId" },
            values: new object[] { new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8807), null });

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 13L,
            columns: new[] { "CreatedOn", "ParentId" },
            values: new object[] { new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8810), null });

        migrationBuilder.InsertData(
            table: "PropertyValues",
            columns: new[] { "Id", "CreatedOn", "LastModifiedOn", "ParentId", "PropertyDefinitionId", "Value" },
            values: new object[,]
            {
                { 14L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8811), null, null, 5L, "Коричневе" },
                { 15L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8813), null, null, 5L, "Кремове" },
                { 16L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8815), null, null, 5L, "Палеве" },
                { 17L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8817), null, null, 5L, "Рудувато-коричневе" },
                { 18L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8819), null, null, 5L, "Золотисте" },
                { 19L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8821), null, null, 5L, "Срібне" },
                { 20L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8823), null, null, 5L, "Блакитне" },
                { 21L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8825), null, null, 5L, "Зелене" },
                { 22L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8827), null, null, 5L, "Жовте" },
                { 23L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8829), null, null, 5L, "Оранжеве" },
                { 24L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8831), null, null, 5L, "Рожеве" },
                { 25L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8833), null, null, 5L, "Фіолетове" },
                { 26L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8835), null, 1L, 2L, "Німецька вівчарка" },
                { 27L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8839), null, 1L, 2L, "Лабрадор-ретрівер" },
                { 28L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8841), null, 1L, 2L, "Йоркширський тер'єр" },
                { 29L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8843), null, 1L, 2L, "Мопс" },
                { 30L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8845), null, 1L, 2L, "Золотистий ретрівер" },
                { 31L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8847), null, 1L, 2L, "Французький бульдог" },
                { 32L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8850), null, 1L, 2L, "Бігль" },
                { 33L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8852), null, 1L, 2L, "Чихуахуа" },
                { 34L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8854), null, 1L, 2L, "Такса" },
                { 35L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8856), null, 1L, 2L, "Сибірський хаскі" },
                { 36L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8858), null, 1L, 2L, "Американський стаффордширський тер'єр" },
                { 37L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8860), null, 1L, 2L, "Кокер-спанієль" },
                { 38L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8862), null, 1L, 2L, "Джек-рассел-тер'єр" },
                { 39L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8864), null, 1L, 2L, "Ши-тцу" },
                { 40L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8866), null, 1L, 2L, "Вест-хайленд-уайт-тер'єр" },
                { 41L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8869), null, 1L, 2L, "Мальтійська болонка" },
                { 42L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8871), null, 1L, 2L, "Боксер" },
                { 43L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8873), null, 1L, 2L, "Доберман" },
                { 44L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8875), null, 1L, 2L, "Шарпей" },
                { 45L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8877), null, 1L, 2L, "Акіта-іну" },
                { 46L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8879), null, 2L, 2L, "Британська короткошерста" },
                { 47L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8881), null, 2L, 2L, "Шотландська висловуха" },
                { 48L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8883), null, 2L, 2L, "Мейн-кун" },
                { 49L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8885), null, 2L, 2L, "Сфінкс" },
                { 50L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8888), null, 2L, 2L, "Перська" },
                { 51L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8890), null, 2L, 2L, "Сіамська" },
                { 52L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8892), null, 2L, 2L, "Європейська короткошерста" },
                { 53L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8894), null, 2L, 2L, "Бенгальська" },
                { 54L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8896), null, 2L, 2L, "Регдолл" },
                { 55L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8898), null, 2L, 2L, "Турецька ангора" },
                { 56L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8900), null, 2L, 2L, "Американська короткошерста" },
                { 57L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8902), null, 2L, 2L, "Невська маскарадна" },
                { 58L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8904), null, 2L, 2L, "Норвезька лісова" },
                { 59L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8906), null, 2L, 2L, "Сомалійська" },
                { 60L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8908), null, 2L, 2L, "Абіссинська" },
                { 61L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8911), null, 2L, 2L, "Орієнтальна" },
                { 62L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8913), null, 2L, 2L, "Екзотична короткошерста" },
                { 63L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8915), null, 2L, 2L, "Девон-рекс" },
                { 64L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8917), null, 2L, 2L, "Саванна" },
                { 65L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8919), null, 2L, 2L, "Бомбейська" },
                { 66L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8921), null, 2L, 2L, "Тонкінська" },
                { 67L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8923), null, null, 6L, "Так" },
                { 68L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8925), null, null, 6L, "Ні" },
                { 69L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8927), null, null, 7L, "Так" },
                { 70L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8929), null, null, 7L, "Ні" },
                { 71L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8931), null, null, 8L, "Так" },
                { 72L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8933), null, null, 8L, "Ні" },
                { 73L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8935), null, null, 9L, "Так" },
                { 74L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8937), null, null, 9L, "Ні" },
                { 75L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8938), null, null, 10L, "Так" },
                { 76L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8940), null, null, 10L, "Ні" },
                { 77L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8942), null, null, 11L, "Так" },
                { 78L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8944), null, null, 11L, "Ні" },
                { 79L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8946), null, null, 12L, "Так" },
                { 80L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8948), null, null, 12L, "Ні" },
                { 81L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8950), null, null, 13L, "Так" },
                { 82L, new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8952), null, null, 13L, "Ні" }
            });

        migrationBuilder.CreateIndex(
            name: "IX_PropertyValues_ParentId",
            table: "PropertyValues",
            column: "ParentId");

        migrationBuilder.AddForeignKey(
            name: "FK_PropertyValues_PropertyValues_ParentId",
            table: "PropertyValues",
            column: "ParentId",
            principalTable: "PropertyValues",
            principalColumn: "Id",
            onDelete: ReferentialAction.SetNull);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_PropertyValues_PropertyValues_ParentId",
            table: "PropertyValues");

        migrationBuilder.DropIndex(
            name: "IX_PropertyValues_ParentId",
            table: "PropertyValues");

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 14L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 15L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 16L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 17L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 18L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 19L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 20L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 21L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 22L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 23L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 24L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 25L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 26L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 27L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 28L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 29L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 30L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 31L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 32L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 33L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 34L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 35L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 36L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 37L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 38L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 39L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 40L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 41L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 42L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 43L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 44L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 45L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 46L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 47L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 48L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 49L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 50L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 51L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 52L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 53L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 54L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 55L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 56L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 57L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 58L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 59L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 60L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 61L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 62L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 63L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 64L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 65L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 66L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 67L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 68L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 69L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 70L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 71L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 72L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 73L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 74L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 75L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 76L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 77L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 78L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 79L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 80L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 81L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 82L);

        migrationBuilder.DeleteData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 6L);

        migrationBuilder.DeleteData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 7L);

        migrationBuilder.DeleteData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 8L);

        migrationBuilder.DeleteData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 9L);

        migrationBuilder.DeleteData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 10L);

        migrationBuilder.DeleteData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 11L);

        migrationBuilder.DeleteData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 12L);

        migrationBuilder.DeleteData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 13L);

        migrationBuilder.DropColumn(
            name: "IsActive",
            table: "Proposals");

        migrationBuilder.DropColumn(
            name: "PetOrigin",
            table: "Proposals");

        migrationBuilder.DropColumn(
            name: "ParentId",
            table: "PropertyValues");

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 1L,
            column: "CreatedOn",
            value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 2L,
            column: "CreatedOn",
            value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 3L,
            column: "CreatedOn",
            value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 4L,
            column: "CreatedOn",
            value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 5L,
            column: "CreatedOn",
            value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 1L,
            column: "CreatedOn",
            value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 2L,
            column: "CreatedOn",
            value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 3L,
            column: "CreatedOn",
            value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 4L,
            column: "CreatedOn",
            value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 5L,
            column: "CreatedOn",
            value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 6L,
            column: "CreatedOn",
            value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 7L,
            column: "CreatedOn",
            value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 8L,
            column: "CreatedOn",
            value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 9L,
            column: "CreatedOn",
            value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 10L,
            column: "CreatedOn",
            value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 11L,
            column: "CreatedOn",
            value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 12L,
            column: "CreatedOn",
            value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 13L,
            column: "CreatedOn",
            value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
    }
}
