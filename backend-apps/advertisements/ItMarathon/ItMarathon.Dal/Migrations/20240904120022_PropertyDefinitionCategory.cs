using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ItMarathon.Dal.Migrations
{
    /// <inheritdoc />
    public partial class PropertyDefinitionCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "PropertiesDefinition",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Category",
                value: null);

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Category",
                value: null);

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Category",
                value: null);

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Category",
                value: null);

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Category", "PropertyDefinitionType" },
                values: new object[] { "Health", 1 });

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Category", "PropertyDefinitionType" },
                values: new object[] { "Health", 1 });

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Category", "PropertyDefinitionType" },
                values: new object[] { "Health", 1 });

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Category", "PropertyDefinitionType" },
                values: new object[] { "Health", 1 });

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Category", "PropertyDefinitionType" },
                values: new object[] { "Documents", 1 });

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Category", "PropertyDefinitionType" },
                values: new object[] { "Documents", 1 });

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Category", "PropertyDefinitionType" },
                values: new object[] { "Documents", 1 });

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Category", "PropertyDefinitionType" },
                values: new object[] { "Documents", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "PropertiesDefinition");

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 6L,
                column: "PropertyDefinitionType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 7L,
                column: "PropertyDefinitionType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 8L,
                column: "PropertyDefinitionType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 9L,
                column: "PropertyDefinitionType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 10L,
                column: "PropertyDefinitionType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 11L,
                column: "PropertyDefinitionType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 12L,
                column: "PropertyDefinitionType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PropertiesDefinition",
                keyColumn: "Id",
                keyValue: 13L,
                column: "PropertyDefinitionType",
                value: 0);

            migrationBuilder.InsertData(
                table: "PropertyValues",
                columns: new[] { "Id", "CreatedOn", "LastModifiedOn", "ParentId", "PropertyDefinitionId", "Value" },
                values: new object[,]
                {
                    { 67L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 6L, "Так" },
                    { 68L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 6L, "Ні" },
                    { 69L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 7L, "Так" },
                    { 70L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 7L, "Ні" },
                    { 71L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 8L, "Так" },
                    { 72L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 8L, "Ні" },
                    { 73L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 9L, "Так" },
                    { 74L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 9L, "Ні" },
                    { 75L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 10L, "Так" },
                    { 76L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 10L, "Ні" },
                    { 77L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11L, "Так" },
                    { 78L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11L, "Ні" },
                    { 79L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 12L, "Так" },
                    { 80L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 12L, "Ні" },
                    { 81L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 13L, "Так" },
                    { 82L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 13L, "Ні" }
                });
        }
    }
}
