using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageLearning.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "WordTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "WordTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WordTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WordTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WordTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "WordTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "WordTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "SentenceTranslationQuestions");

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

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "InfillQuestions");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "InfillQuestions");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "InfillQuestions");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "InfillQuestions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "InfillQuestions");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "InfillQuestions");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "InfillQuestions");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Comments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "WordTranslationQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "WordTranslationQuestions",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WordTranslationQuestions",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WordTranslationQuestions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WordTranslationQuestions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "WordTranslationQuestions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "WordTranslationQuestions",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Words",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Words",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Words",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Words",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Words",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Words",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Words",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "SentenceTranslationQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "SentenceTranslationQuestions",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "SentenceTranslationQuestions",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "SentenceTranslationQuestions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SentenceTranslationQuestions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "SentenceTranslationQuestions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "SentenceTranslationQuestions",
                type: "bigint",
                nullable: true);

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

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Sections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Sections",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Sections",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Sections",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Sections",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Sections",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Sections",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Lessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Lessons",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Lessons",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Lessons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Lessons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Lessons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Lessons",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Languages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Languages",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Languages",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Languages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Languages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Languages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Languages",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "InfillQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "InfillQuestions",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "InfillQuestions",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "InfillQuestions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "InfillQuestions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "InfillQuestions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "InfillQuestions",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Exams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Exams",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Exams",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Exams",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Exams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Exams",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Exams",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Comments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Comments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Comments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Comments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Comments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Comments",
                type: "bigint",
                nullable: true);
        }
    }
}
