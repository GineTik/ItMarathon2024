using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItMarathon.Dal.Migrations;

/// <inheritdoc />
public partial class UpdateMandatoryValue : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 5L,
            column: "IsMandatory",
            value: false);

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 6L,
            column: "IsMandatory",
            value: false);

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 7L,
            column: "IsMandatory",
            value: false);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 5L,
            column: "IsMandatory",
            value: true);

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 6L,
            column: "IsMandatory",
            value: true);

        migrationBuilder.UpdateData(
            table: "PropertiesDefinition",
            keyColumn: "Id",
            keyValue: 7L,
            column: "IsMandatory",
            value: true);
    }
}
