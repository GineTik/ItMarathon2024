using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItMarathon.Dal.Migrations
{
    /// <inheritdoc />
    public partial class AgeProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Proposals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Proposals");

            migrationBuilder.InsertData(
                table: "PropertiesDefinition",
                columns: new[] { "Id", "CreatedOn", "IsMandatory", "LastModifiedOn", "Name", "PropertyDefinitionType" },
                values: new object[] { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Вік", 1 });
        }
    }
}
