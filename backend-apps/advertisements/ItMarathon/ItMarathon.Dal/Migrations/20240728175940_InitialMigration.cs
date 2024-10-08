using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ItMarathon.Dal.Migrations;

/// <inheritdoc />
public partial class InitialMigration : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterDatabase()
            .Annotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.CreateTable(
            name: "AppUsers",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                Surname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                Address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                PhoneNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AppUsers", x => x.Id);
            })
            .Annotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.CreateTable(
            name: "PropertiesDefinition",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                PropertyDefinitionType = table.Column<int>(type: "int", nullable: false),
                IsMandatory = table.Column<bool>(type: "tinyint(1)", nullable: false),
                CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_PropertiesDefinition", x => x.Id);
            })
            .Annotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.CreateTable(
            name: "Proposals",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                AppUserId = table.Column<long>(type: "bigint", nullable: false),
                Title = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                PetName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                Price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                Summary = table.Column<string>(type: "varchar(1500)", maxLength: 1500, nullable: false)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                Location = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Proposals", x => x.Id);
                table.ForeignKey(
                    name: "FK_Proposals_AppUsers_AppUserId",
                    column: x => x.AppUserId,
                    principalTable: "AppUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            })
            .Annotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.CreateTable(
            name: "Requests",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                AppUserId = table.Column<long>(type: "bigint", nullable: false),
                Title = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Requests", x => x.Id);
                table.ForeignKey(
                    name: "FK_Requests_AppUsers_AppUserId",
                    column: x => x.AppUserId,
                    principalTable: "AppUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            })
            .Annotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.CreateTable(
            name: "PropertyValues",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                PropertyDefinitionId = table.Column<long>(type: "bigint", nullable: false),
                Value = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_PropertyValues", x => x.Id);
                table.ForeignKey(
                    name: "FK_PropertyValues_PropertiesDefinition_PropertyDefinitionId",
                    column: x => x.PropertyDefinitionId,
                    principalTable: "PropertiesDefinition",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            })
            .Annotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.CreateTable(
            name: "ProposalsPhoto",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                ProposalId = table.Column<long>(type: "bigint", nullable: false),
                Url = table.Column<string>(type: "varchar(2048)", maxLength: 2048, nullable: false)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ProposalsPhoto", x => x.Id);
                table.ForeignKey(
                    name: "FK_ProposalsPhoto_Proposals_ProposalId",
                    column: x => x.ProposalId,
                    principalTable: "Proposals",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            })
            .Annotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.CreateTable(
            name: "Properties",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                PropertyDefinitionId = table.Column<long>(type: "bigint", nullable: false),
                PredefinedValueId = table.Column<long>(type: "bigint", nullable: true),
                CustomValue = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                ProposalId = table.Column<long>(type: "bigint", nullable: true),
                RequestId = table.Column<long>(type: "bigint", nullable: true),
                CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Properties", x => x.Id);
                table.CheckConstraint("CK_Property_ProposalId_RequestId", "ProposalId IS NOT NULL OR RequestId IS NOT NULL");
                table.ForeignKey(
                    name: "FK_Properties_PropertiesDefinition_PropertyDefinitionId",
                    column: x => x.PropertyDefinitionId,
                    principalTable: "PropertiesDefinition",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Properties_PropertyValues_PredefinedValueId",
                    column: x => x.PredefinedValueId,
                    principalTable: "PropertyValues",
                    principalColumn: "Id");
                table.ForeignKey(
                    name: "FK_Properties_Proposals_ProposalId",
                    column: x => x.ProposalId,
                    principalTable: "Proposals",
                    principalColumn: "Id");
                table.ForeignKey(
                    name: "FK_Properties_Requests_RequestId",
                    column: x => x.RequestId,
                    principalTable: "Requests",
                    principalColumn: "Id");
            })
            .Annotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.InsertData(
            table: "PropertiesDefinition",
            columns: new[] { "Id", "CreatedOn", "IsMandatory", "LastModifiedOn", "Name", "PropertyDefinitionType" },
            values: new object[,]
            {
                { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Вид тварини", 0 },
                { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Порода", 0 },
                { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Стать", 0 },
                { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Вік", 0 },
                { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Забарвлення", 0 }
            });

        migrationBuilder.InsertData(
            table: "PropertyValues",
            columns: new[] { "Id", "CreatedOn", "LastModifiedOn", "PropertyDefinitionId", "Value" },
            values: new object[,]
            {
                { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, "Собаки" },
                { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, "Коти" },
                { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, "Гризуни" },
                { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, "Риби" },
                { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, "Птахи" },
                { 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, "Рептилії" },
                { 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, "Інші" },
                { 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3L, "Хлопчик" },
                { 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3L, "Дівчинка" },
                { 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5L, "Руде" },
                { 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5L, "Біле" },
                { 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5L, "Чорне" },
                { 13L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5L, "Сіре" }
            });

        migrationBuilder.CreateIndex(
            name: "IX_Properties_PredefinedValueId",
            table: "Properties",
            column: "PredefinedValueId",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "IX_Properties_PropertyDefinitionId",
            table: "Properties",
            column: "PropertyDefinitionId");

        migrationBuilder.CreateIndex(
            name: "IX_Properties_ProposalId",
            table: "Properties",
            column: "ProposalId");

        migrationBuilder.CreateIndex(
            name: "IX_Properties_RequestId",
            table: "Properties",
            column: "RequestId");

        migrationBuilder.CreateIndex(
            name: "IX_PropertyValues_PropertyDefinitionId",
            table: "PropertyValues",
            column: "PropertyDefinitionId");

        migrationBuilder.CreateIndex(
            name: "IX_Proposals_AppUserId",
            table: "Proposals",
            column: "AppUserId");

        migrationBuilder.CreateIndex(
            name: "IX_ProposalsPhoto_ProposalId",
            table: "ProposalsPhoto",
            column: "ProposalId");

        migrationBuilder.CreateIndex(
            name: "IX_Requests_AppUserId",
            table: "Requests",
            column: "AppUserId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Properties");

        migrationBuilder.DropTable(
            name: "ProposalsPhoto");

        migrationBuilder.DropTable(
            name: "PropertyValues");

        migrationBuilder.DropTable(
            name: "Requests");

        migrationBuilder.DropTable(
            name: "Proposals");

        migrationBuilder.DropTable(
            name: "PropertiesDefinition");

        migrationBuilder.DropTable(
            name: "AppUsers");
    }
}
