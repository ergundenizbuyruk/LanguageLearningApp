using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageLearning.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Sentences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Sentences",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Sentences",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Sentences",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Sentences",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Sentences",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Sentences",
                type: "bigint",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Sentences");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Sentences");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Sentences");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Sentences");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Sentences");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Sentences");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Sentences");
        }
    }
}
