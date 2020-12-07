using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Crud.App.Data.Migrations
{
    public partial class itemGroupFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemsGroups_ItemsGroups_ParentItemsGroupID",
                table: "ItemsGroups");

            migrationBuilder.AlterColumn<Guid>(
                name: "ParentItemsGroupID",
                table: "ItemsGroups",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "ParentItemsGroupID",
                table: "ItemsGroups",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsGroups_ItemsGroups_ParentItemsGroupID",
                table: "ItemsGroups",
                column: "ParentItemsGroupID",
                principalTable: "ItemsGroups",
                principalColumn: "ItemsGroupID",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
