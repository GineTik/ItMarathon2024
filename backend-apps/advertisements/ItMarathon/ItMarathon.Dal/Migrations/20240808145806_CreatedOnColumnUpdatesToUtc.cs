using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItMarathon.Dal.Migrations;

/// <inheritdoc />
public partial class CreatedOnColumnUpdatesToUtc : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 1L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(5136));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 2L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(5140));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 3L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(5141));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 4L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(5142));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 5L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(5143));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 6L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(5144));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 7L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(5144));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 8L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(5145));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 9L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(5146));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 10L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(5147));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 11L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(5147));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 12L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(5148));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 13L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(5149));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 1L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7210));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 2L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7211));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 3L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7212));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 4L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7213));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 5L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7213));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 6L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7214));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 7L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7215));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 8L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7216));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 9L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7216));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 10L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7217));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 11L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7218));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 12L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7219));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 13L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7219));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 14L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7220));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 15L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7221));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 16L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7222));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 17L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7222));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 18L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7223));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 19L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7224));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 20L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7225));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 21L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7225));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 22L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7226));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 23L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7227));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 24L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7228));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 25L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7228));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 26L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7229));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 27L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7232));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 28L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7233));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 29L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7234));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 30L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7235));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 31L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7236));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 32L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7237));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 33L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7238));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 34L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7239));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 35L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7239));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 36L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7240));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 37L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7241));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 38L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7242));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 39L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7243));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 40L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7244));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 41L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7245));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 42L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7246));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 43L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7293));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 44L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7295));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 45L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7296));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 46L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7297));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 47L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7298));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 48L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7298));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 49L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7299));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 50L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7300));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 51L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7301));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 52L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7302));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 53L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7303));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 54L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7304));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 55L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7305));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 56L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7306));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 57L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7307));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 58L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7308));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 59L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7309));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 60L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7310));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 61L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7311));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 62L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7312));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 63L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7312));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 64L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7313));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 65L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7314));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 66L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7315));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 67L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7316));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 68L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7317));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 69L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7318));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 70L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7319));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 71L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7320));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 72L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7320));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 73L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7321));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 74L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7322));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 75L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7322));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 76L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7323));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 77L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7324));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 78L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7325));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 79L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7325));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 80L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7326));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 81L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7327));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 82L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 8, 14, 58, 6, 141, DateTimeKind.Utc).AddTicks(7328));
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
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

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 6L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7130));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 7L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7132));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 8L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7134));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 9L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7136));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 10L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7138));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 11L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7140));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 12L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7142));

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 13L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(7144));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 1L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8750));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 2L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8763));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 3L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8765));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 4L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8767));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 5L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8769));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 6L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8771));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 7L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8773));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 8L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8799));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 9L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8802));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 10L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8804));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 11L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8806));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 12L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8807));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 13L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8810));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 14L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8811));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 15L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8813));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 16L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8815));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 17L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8817));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 18L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8819));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 19L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8821));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 20L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8823));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 21L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8825));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 22L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8827));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 23L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8829));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 24L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8831));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 25L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8833));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 26L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8835));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 27L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8839));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 28L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8841));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 29L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8843));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 30L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8845));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 31L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8847));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 32L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8850));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 33L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8852));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 34L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8854));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 35L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8856));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 36L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8858));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 37L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8860));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 38L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8862));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 39L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8864));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 40L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8866));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 41L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8869));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 42L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8871));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 43L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8873));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 44L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8875));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 45L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8877));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 46L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8879));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 47L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8881));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 48L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8883));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 49L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8885));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 50L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8888));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 51L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8890));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 52L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8892));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 53L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8894));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 54L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8896));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 55L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8898));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 56L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8900));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 57L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8902));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 58L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8904));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 59L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8906));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 60L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8908));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 61L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8911));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 62L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8913));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 63L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8915));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 64L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8917));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 65L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8919));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 66L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8921));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 67L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8923));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 68L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8925));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 69L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8927));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 70L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8929));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 71L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8931));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 72L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8933));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 73L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8935));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 74L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8937));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 75L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8938));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 76L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8940));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 77L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8942));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 78L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8944));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 79L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8946));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 80L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8948));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 81L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8950));

        migrationBuilder.UpdateData(
            table: "PropertyValues",
            keyColumn: "Id",
            keyValue: 82L,
            column: "CreatedOn",
            value: new DateTime(2024, 8, 4, 1, 47, 31, 192, DateTimeKind.Local).AddTicks(8952));
    }
}
