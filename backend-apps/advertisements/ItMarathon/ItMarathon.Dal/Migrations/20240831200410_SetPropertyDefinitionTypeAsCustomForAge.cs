using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItMarathon.Dal.Migrations
{
    /// <inheritdoc />
    public partial class SetPropertyDefinitionTypeAsCustomForAge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 4L,
                column: "PropertyDefinitionType",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 4L,
                column: "PropertyDefinitionType",
                value: 0);
        }
    }
}
