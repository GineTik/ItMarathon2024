using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItMarathon.Dal.Migrations;

/// <inheritdoc />
public partial class UpdateUsersSchema : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        NormalizeUserDataForMigration(migrationBuilder);

        migrationBuilder.DropForeignKey(
            name: "FK_Proposals_AppUsers_AppUserId",
            table: "Proposals");

        migrationBuilder.DropForeignKey(
            name: "FK_Requests_AppUsers_AppUserId",
            table: "Requests");

        migrationBuilder.DropPrimaryKey(
            name: "PK_AppUsers",
            table: "AppUsers");

        migrationBuilder.DropColumn(
            name: "Address",
            table: "AppUsers");

        migrationBuilder.RenameTable(
            name: "AppUsers",
            newName: "users");

        migrationBuilder.RenameColumn(
            name: "Surname",
            table: "users",
            newName: "surname");

        migrationBuilder.RenameColumn(
            name: "Name",
            table: "users",
            newName: "name");

        migrationBuilder.RenameColumn(
            name: "Email",
            table: "users",
            newName: "email");

        migrationBuilder.RenameColumn(
            name: "Id",
            table: "users",
            newName: "id");

        migrationBuilder.RenameColumn(
            name: "PhoneNumber",
            table: "users",
            newName: "phone_number");

        migrationBuilder.RenameColumn(
            name: "LastModifiedOn",
            table: "users",
            newName: "last_modified_on");

        migrationBuilder.RenameColumn(
            name: "CreatedOn",
            table: "users",
            newName: "created_on");

        migrationBuilder.UpdateData(
            table: "users",
            keyColumn: "surname",
            keyValue: null,
            column: "surname",
            value: "");

        migrationBuilder.AlterColumn<string>(
            name: "surname",
            table: "users",
            type: "varchar(50)",
            maxLength: 50,
            nullable: false,
            oldClrType: typeof(string),
            oldType: "varchar(50)",
            oldMaxLength: 50,
            oldNullable: true)
            .Annotation("MySql:CharSet", "utf8mb4")
            .OldAnnotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.UpdateData(
            table: "users",
            keyColumn: "name",
            keyValue: null,
            column: "name",
            value: "");

        migrationBuilder.AlterColumn<string>(
            name: "name",
            table: "users",
            type: "varchar(50)",
            maxLength: 50,
            nullable: false,
            oldClrType: typeof(string),
            oldType: "varchar(30)",
            oldMaxLength: 30,
            oldNullable: true)
            .Annotation("MySql:CharSet", "utf8mb4")
            .OldAnnotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.AlterColumn<string>(
            name: "email",
            table: "users",
            type: "varchar(320)",
            maxLength: 320,
            nullable: false,
            oldClrType: typeof(string),
            oldType: "varchar(100)",
            oldMaxLength: 100)
            .Annotation("MySql:CharSet", "utf8mb4")
            .OldAnnotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.AlterColumn<string>(
            name: "phone_number",
            table: "users",
            type: "varchar(15)",
            maxLength: 15,
            nullable: true,
            oldClrType: typeof(string),
            oldType: "varchar(20)",
            oldMaxLength: 20,
            oldNullable: true)
            .Annotation("MySql:CharSet", "utf8mb4")
            .OldAnnotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.AlterColumn<DateTime>(
            name: "last_modified_on",
            table: "users",
            type: "datetime",
            nullable: false,
            defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
            oldClrType: typeof(DateTime),
            oldType: "datetime(6)",
            oldNullable: true);

        migrationBuilder.AlterColumn<DateTime>(
            name: "created_on",
            table: "users",
            type: "datetime",
            nullable: false,
            oldClrType: typeof(DateTime),
            oldType: "datetime(6)");

        migrationBuilder.AddColumn<string>(
            name: "hashed_password",
            table: "users",
            type: "varchar(1024)",
            maxLength: 1024,
            nullable: false,
            defaultValue: "")
            .Annotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.AddColumn<bool>(
            name: "is_active",
            table: "users",
            type: "tinyint(1)",
            nullable: false,
            defaultValue: false);

        migrationBuilder.AddColumn<bool>(
            name: "is_superuser",
            table: "users",
            type: "tinyint(1)",
            nullable: false,
            defaultValue: false);

        migrationBuilder.AddColumn<bool>(
            name: "is_verified",
            table: "users",
            type: "tinyint(1)",
            nullable: false,
            defaultValue: false);

        migrationBuilder.AddColumn<string>(
            name: "location",
            table: "users",
            type: "varchar(120)",
            maxLength: 120,
            nullable: false,
            defaultValue: "")
            .Annotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.AddColumn<bool>(
            name: "prefers_phone_call",
            table: "users",
            type: "tinyint(1)",
            nullable: false,
            defaultValue: false);

        migrationBuilder.AddColumn<bool>(
            name: "prefers_telegram",
            table: "users",
            type: "tinyint(1)",
            nullable: false,
            defaultValue: false);

        migrationBuilder.AddPrimaryKey(
            name: "PK_users",
            table: "users",
            column: "id");

        migrationBuilder.CreateTable(
            name: "access_tokens",
            columns: table => new
            {
                token = table.Column<string>(type: "varchar(43)", maxLength: 43, nullable: false)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                user_id = table.Column<long>(type: "bigint", nullable: false),
                created_at = table.Column<DateTime>(type: "timestamp", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_access_tokens", x => x.token);
                table.ForeignKey(
                    name: "fk_access_tokens_user_id_users",
                    column: x => x.user_id,
                    principalTable: "users",
                    principalColumn: "id",
                    onDelete: ReferentialAction.Cascade);
            })
            .Annotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.CreateIndex(
            name: "ix_users_email",
            table: "users",
            column: "email",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "fk_access_tokens_user_id_users",
            table: "access_tokens",
            column: "user_id");

        migrationBuilder.CreateIndex(
            name: "ix_access_tokens_created_at",
            table: "access_tokens",
            column: "created_at");

        migrationBuilder.AddForeignKey(
            name: "FK_Proposals_users_AppUserId",
            table: "Proposals",
            column: "AppUserId",
            principalTable: "users",
            principalColumn: "id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_Requests_users_AppUserId",
            table: "Requests",
            column: "AppUserId",
            principalTable: "users",
            principalColumn: "id",
            onDelete: ReferentialAction.Cascade);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Proposals_users_AppUserId",
            table: "Proposals");

        migrationBuilder.DropForeignKey(
            name: "FK_Requests_users_AppUserId",
            table: "Requests");

        migrationBuilder.DropTable(
            name: "access_tokens");

        migrationBuilder.DropPrimaryKey(
            name: "PK_users",
            table: "users");

        migrationBuilder.DropIndex(
            name: "ix_users_email",
            table: "users");

        migrationBuilder.DropColumn(
            name: "hashed_password",
            table: "users");

        migrationBuilder.DropColumn(
            name: "is_active",
            table: "users");

        migrationBuilder.DropColumn(
            name: "is_superuser",
            table: "users");

        migrationBuilder.DropColumn(
            name: "is_verified",
            table: "users");

        migrationBuilder.DropColumn(
            name: "location",
            table: "users");

        migrationBuilder.DropColumn(
            name: "prefers_phone_call",
            table: "users");

        migrationBuilder.DropColumn(
            name: "prefers_telegram",
            table: "users");

        migrationBuilder.RenameTable(
            name: "users",
            newName: "AppUsers");

        migrationBuilder.RenameColumn(
            name: "surname",
            table: "AppUsers",
            newName: "Surname");

        migrationBuilder.RenameColumn(
            name: "name",
            table: "AppUsers",
            newName: "Name");

        migrationBuilder.RenameColumn(
            name: "email",
            table: "AppUsers",
            newName: "Email");

        migrationBuilder.RenameColumn(
            name: "id",
            table: "AppUsers",
            newName: "Id");

        migrationBuilder.RenameColumn(
            name: "phone_number",
            table: "AppUsers",
            newName: "PhoneNumber");

        migrationBuilder.RenameColumn(
            name: "last_modified_on",
            table: "AppUsers",
            newName: "LastModifiedOn");

        migrationBuilder.RenameColumn(
            name: "created_on",
            table: "AppUsers",
            newName: "CreatedOn");

        migrationBuilder.AlterColumn<string>(
            name: "Surname",
            table: "AppUsers",
            type: "varchar(50)",
            maxLength: 50,
            nullable: true,
            oldClrType: typeof(string),
            oldType: "varchar(50)",
            oldMaxLength: 50)
            .Annotation("MySql:CharSet", "utf8mb4")
            .OldAnnotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.AlterColumn<string>(
            name: "Name",
            table: "AppUsers",
            type: "varchar(30)",
            maxLength: 30,
            nullable: true,
            oldClrType: typeof(string),
            oldType: "varchar(50)",
            oldMaxLength: 50)
            .Annotation("MySql:CharSet", "utf8mb4")
            .OldAnnotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.AlterColumn<string>(
            name: "Email",
            table: "AppUsers",
            type: "varchar(100)",
            maxLength: 100,
            nullable: false,
            oldClrType: typeof(string),
            oldType: "varchar(320)",
            oldMaxLength: 320)
            .Annotation("MySql:CharSet", "utf8mb4")
            .OldAnnotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.AlterColumn<string>(
            name: "PhoneNumber",
            table: "AppUsers",
            type: "varchar(20)",
            maxLength: 20,
            nullable: true,
            oldClrType: typeof(string),
            oldType: "varchar(15)",
            oldMaxLength: 15,
            oldNullable: true)
            .Annotation("MySql:CharSet", "utf8mb4")
            .OldAnnotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.AlterColumn<DateTime>(
            name: "LastModifiedOn",
            table: "AppUsers",
            type: "datetime(6)",
            nullable: true,
            oldClrType: typeof(DateTime),
            oldType: "datetime");

        migrationBuilder.AlterColumn<DateTime>(
            name: "CreatedOn",
            table: "AppUsers",
            type: "datetime(6)",
            nullable: false,
            oldClrType: typeof(DateTime),
            oldType: "datetime");

        migrationBuilder.AddColumn<string>(
            name: "Address",
            table: "AppUsers",
            type: "varchar(50)",
            maxLength: 50,
            nullable: true)
            .Annotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.AddPrimaryKey(
            name: "PK_AppUsers",
            table: "AppUsers",
            column: "Id");

        migrationBuilder.AddForeignKey(
            name: "FK_Proposals_AppUsers_AppUserId",
            table: "Proposals",
            column: "AppUserId",
            principalTable: "AppUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_Requests_AppUsers_AppUserId",
            table: "Requests",
            column: "AppUserId",
            principalTable: "AppUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    }

    private void NormalizeUserDataForMigration(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql(@"
                 UPDATE AppUsers 
                 SET Name = 'Unknown' 
                 WHERE Name IS NULL OR Name = '';

                 UPDATE AppUsers 
                 SET Surname = 'Unknown' 
                 WHERE Surname IS NULL OR Surname = '';

                 UPDATE AppUsers 
                 SET LastModifiedOn = CreatedOn 
                 WHERE LastModifiedOn IS NULL;
            ");

        migrationBuilder.Sql(@"
                 UPDATE AppUsers
                 SET PhoneNumber = REPLACE(PhoneNumber, '+', '');
    
                 UPDATE AppUsers
                 SET PhoneNumber = REPLACE(PhoneNumber, ' ', '');
    
                 UPDATE AppUsers
                 SET PhoneNumber = REPLACE(PhoneNumber, ')', '');
    
                 UPDATE AppUsers
                 SET PhoneNumber = REPLACE(PhoneNumber, '(', '');
    
                 UPDATE AppUsers
                 SET PhoneNumber = SUBSTRING(PhoneNumber, 1, 15)
                 WHERE LENGTH(PhoneNumber) > 15;
            ");
    }
}
