using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Crud.App.Data.Migrations
{
    public partial class itemGroupID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemsGroups_ItemsGroups_ItemsGroupID1",
                table: "ItemsGroups");

            migrationBuilder.DropIndex(
                name: "IX_ItemsGroups_ItemsGroupID1",
                table: "ItemsGroups");

            migrationBuilder.DropColumn(
                name: "ItemsGroupID1",
                table: "ItemsGroups");

            migrationBuilder.DropColumn(
                name: "ParentItemsGroupCode",
                table: "ItemsGroups");

            migrationBuilder.AddColumn<Guid>(
                name: "ParentItemsGroupID",
                table: "ItemsGroups",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ItemsGroups_ParentItemsGroupID",
                table: "ItemsGroups",
                column: "ParentItemsGroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsGroups_ItemsGroups_ParentItemsGroupID",
                table: "ItemsGroups",
                column: "ParentItemsGroupID",
                principalTable: "ItemsGroups",
                principalColumn: "ItemsGroupID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemsGroups_ItemsGroups_ParentItemsGroupID",
                table: "ItemsGroups");

            migrationBuilder.DropIndex(
                name: "IX_ItemsGroups_ParentItemsGroupID",
                table: "ItemsGroups");

            migrationBuilder.DropColumn(
                name: "ParentItemsGroupID",
                table: "ItemsGroups");

            migrationBuilder.AddColumn<Guid>(
                name: "ItemsGroupID1",
                table: "ItemsGroups",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentItemsGroupCode",
                table: "ItemsGroups",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsGroups_ItemsGroupID1",
                table: "ItemsGroups",
                column: "ItemsGroupID1");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsGroups_ItemsGroups_ItemsGroupID1",
                table: "ItemsGroups",
                column: "ItemsGroupID1",
                principalTable: "ItemsGroups",
                principalColumn: "ItemsGroupID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
