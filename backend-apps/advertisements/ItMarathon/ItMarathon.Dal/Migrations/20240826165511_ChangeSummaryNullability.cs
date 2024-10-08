using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItMarathon.Dal.Migrations;

/// <inheritdoc />
public partial class ChangeSummaryNullability : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterColumn<string>(
            name: "Summary",
            table: "Proposals",
            type: "varchar(1500)",
            maxLength: 1500,
            nullable: true,
            oldClrType: typeof(string),
            oldType: "varchar(1500)",
            oldMaxLength: 1500)
            .Annotation("MySql:CharSet", "utf8mb4")
            .OldAnnotation("MySql:CharSet", "utf8mb4");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.UpdateData(
            table: "Proposals",
            keyColumn: "Summary",
            keyValue: null,
            column: "Summary",
            value: "");

        migrationBuilder.AlterColumn<string>(
            name: "Summary",
            table: "Proposals",
            type: "varchar(1500)",
            maxLength: 1500,
            nullable: false,
            oldClrType: typeof(string),
            oldType: "varchar(1500)",
            oldMaxLength: 1500,
            oldNullable: true)
            .Annotation("MySql:CharSet", "utf8mb4")
            .OldAnnotation("MySql:CharSet", "utf8mb4");
    }
}
