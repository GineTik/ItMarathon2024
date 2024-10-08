using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItMarathon.Dal.Migrations;

/// <inheritdoc />
public partial class AddIndexesAndUpdateDeleteBehavior : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Properties_PropertyValues_PredefinedValueId",
            table: "Properties");

        migrationBuilder.DropForeignKey(
            name: "FK_Properties_Proposals_ProposalId",
            table: "Properties");

        migrationBuilder.CreateIndex(
            name: "IX_Proposals_Location",
            table: "Proposals",
            column: "Location");

        migrationBuilder.CreateIndex(
            name: "IX_Proposals_Price",
            table: "Proposals",
            column: "Price");

        migrationBuilder.CreateIndex(
            name: "IX_PropertyValues_Value",
            table: "PropertyValues",
            column: "Value");

        migrationBuilder.CreateIndex(
            name: "IX_PropertiesDefinition_Name",
            table: "PropertiesDefinition",
            column: "Name",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "IX_Properties_CustomValue",
            table: "Properties",
            column: "CustomValue");

        migrationBuilder.CreateIndex(
            name: "IX_Properties_PredefinedValueId_NonUnique",
            table: "Properties",
            column: "PredefinedValueId",
            unique: false);

        migrationBuilder.DropIndex(
            name: "IX_Properties_PredefinedValueId",
            table: "Properties");

        migrationBuilder.AddForeignKey(
            name: "FK_Properties_PropertyValues_PredefinedValueId",
            table: "Properties",
            column: "PredefinedValueId",
            principalTable: "PropertyValues",
            principalColumn: "Id",
            onDelete: ReferentialAction.SetNull);

        migrationBuilder.AddForeignKey(
            name: "FK_Properties_Proposals_ProposalId",
            table: "Properties",
            column: "ProposalId",
            principalTable: "Proposals",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Properties_PropertyValues_PredefinedValueId",
            table: "Properties");

        migrationBuilder.DropForeignKey(
            name: "FK_Properties_Proposals_ProposalId",
            table: "Properties");

        migrationBuilder.DropIndex(
            name: "IX_Proposals_Location",
            table: "Proposals");

        migrationBuilder.DropIndex(
            name: "IX_Proposals_Price",
            table: "Proposals");

        migrationBuilder.DropIndex(
            name: "IX_PropertyValues_Value",
            table: "PropertyValues");

        migrationBuilder.DropIndex(
            name: "IX_PropertiesDefinition_Name",
            table: "PropertiesDefinition");

        migrationBuilder.DropIndex(
            name: "IX_Properties_CustomValue",
            table: "Properties");

        migrationBuilder.DropIndex(
            name: "IX_Properties_PredefinedValueId_NonUnique",
            table: "Properties");

        migrationBuilder.CreateIndex(
            name: "IX_Properties_PredefinedValueId",
            table: "Properties",
            column: "PredefinedValueId",
            unique: true);

        migrationBuilder.AddForeignKey(
            name: "FK_Properties_PropertyValues_PredefinedValueId",
            table: "Properties",
            column: "PredefinedValueId",
            principalTable: "PropertyValues",
            principalColumn: "Id");

        migrationBuilder.AddForeignKey(
            name: "FK_Properties_Proposals_ProposalId",
            table: "Properties",
            column: "ProposalId",
            principalTable: "Proposals",
            principalColumn: "Id");
    }
}
