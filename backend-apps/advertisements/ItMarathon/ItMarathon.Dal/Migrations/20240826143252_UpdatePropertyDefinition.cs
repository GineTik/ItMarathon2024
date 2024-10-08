using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ItMarathon.Dal.Migrations;

/// <inheritdoc />
public partial class UpdatePropertyDefinition : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.InsertData(
            table: "PropertyValues",
            columns: new[] { "Id", "CreatedOn", "LastModifiedOn", "ParentId", "PropertyDefinitionId", "Value" },
            values: new object[,]
            {
                { 154L, new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc), null, null, 3L, "Невідомо" },
                { 155L, new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc), null, null, 5L, "Інше" },
                { 156L, new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc), null, 1L, 2L, "Інше" },
                { 157L, new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc), null, 2L, 2L, "Інше" },
                { 158L, new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc), null, 3L, 2L, "Інше" },
                { 159L, new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc), null, 4L, 2L, "Інше" },
                { 160L, new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc), null, 5L, 2L, "Інше" },
                { 161L, new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc), null, 6L, 2L, "Інше" },
                { 162L, new DateTime(2024, 8, 16, 17, 4, 10, 300, DateTimeKind.Utc), null, 7L, 2L, "Інше" }
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 154L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 155L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 156L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 157L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 158L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 159L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 160L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 161L);

        migrationBuilder.DeleteData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 162L);
    }
}
