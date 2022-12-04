using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageLearning.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Sections_SectionId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Sections_SectionId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_InfillQuestions_Exams_ExamId",
                table: "InfillQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_InfillQuestions_Sections_SectionId",
                table: "InfillQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_SentenceTranslationQuestions_Exams_ExamId",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_SentenceTranslationQuestions_Sections_SectionId",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_WordTranslationQuestions_Exams_ExamId",
                table: "WordTranslationQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_WordTranslationQuestions_Sections_SectionId",
                table: "WordTranslationQuestions");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_WordTranslationQuestions_ExamId",
                table: "WordTranslationQuestions");

            migrationBuilder.DropIndex(
                name: "IX_WordTranslationQuestions_SectionId",
                table: "WordTranslationQuestions");

            migrationBuilder.DropIndex(
                name: "IX_SentenceTranslationQuestions_ExamId",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropIndex(
                name: "IX_SentenceTranslationQuestions_SectionId",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropIndex(
                name: "IX_InfillQuestions_ExamId",
                table: "InfillQuestions");

            migrationBuilder.DropIndex(
                name: "IX_InfillQuestions_SectionId",
                table: "InfillQuestions");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "WordTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "WordTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "EnglishWord",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "CorrectOption",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "OptionA",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "OptionB",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "OptionC",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "OptionD",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "InfillQuestions");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "InfillQuestions");

            migrationBuilder.RenameColumn(
                name: "TurkishWord",
                table: "Words",
                newName: "EnglishSentence");

            migrationBuilder.RenameColumn(
                name: "Sentence",
                table: "SentenceTranslationQuestions",
                newName: "EnglishSentence");

            migrationBuilder.RenameColumn(
                name: "SectionId",
                table: "Exams",
                newName: "LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_Exams_SectionId",
                table: "Exams",
                newName: "IX_Exams_LessonId");

            migrationBuilder.RenameColumn(
                name: "SectionId",
                table: "Comments",
                newName: "LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_SectionId",
                table: "Comments",
                newName: "IX_Comments_LessonId");

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

            migrationBuilder.AddColumn<int>(
                name: "LessonId",
                table: "WordTranslationQuestions",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddColumn<int>(
                name: "LessonId",
                table: "Words",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddColumn<int>(
                name: "LessonId",
                table: "SentenceTranslationQuestions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LessonId",
                table: "Sentences",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddColumn<int>(
                name: "LessonId",
                table: "InfillQuestions",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "Exams",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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

            migrationBuilder.CreateIndex(
                name: "IX_WordTranslationQuestions_LessonId",
                table: "WordTranslationQuestions",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Words_LessonId",
                table: "Words",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_SentenceTranslationQuestions_LessonId",
                table: "SentenceTranslationQuestions",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Sentences_LessonId",
                table: "Sentences",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_InfillQuestions_LessonId",
                table: "InfillQuestions",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_UserId",
                table: "Exams",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Lessons_LessonId",
                table: "Comments",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_AbpUsers_UserId",
                table: "Exams",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Lessons_LessonId",
                table: "Exams",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InfillQuestions_Lessons_LessonId",
                table: "InfillQuestions",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sentences_Lessons_LessonId",
                table: "Sentences",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SentenceTranslationQuestions_Lessons_LessonId",
                table: "SentenceTranslationQuestions",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Words_Lessons_LessonId",
                table: "Words",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WordTranslationQuestions_Lessons_LessonId",
                table: "WordTranslationQuestions",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Lessons_LessonId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_AbpUsers_UserId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Lessons_LessonId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_InfillQuestions_Lessons_LessonId",
                table: "InfillQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sentences_Lessons_LessonId",
                table: "Sentences");

            migrationBuilder.DropForeignKey(
                name: "FK_SentenceTranslationQuestions_Lessons_LessonId",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_Words_Lessons_LessonId",
                table: "Words");

            migrationBuilder.DropForeignKey(
                name: "FK_WordTranslationQuestions_Lessons_LessonId",
                table: "WordTranslationQuestions");

            migrationBuilder.DropIndex(
                name: "IX_WordTranslationQuestions_LessonId",
                table: "WordTranslationQuestions");

            migrationBuilder.DropIndex(
                name: "IX_Words_LessonId",
                table: "Words");

            migrationBuilder.DropIndex(
                name: "IX_SentenceTranslationQuestions_LessonId",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropIndex(
                name: "IX_Sentences_LessonId",
                table: "Sentences");

            migrationBuilder.DropIndex(
                name: "IX_InfillQuestions_LessonId",
                table: "InfillQuestions");

            migrationBuilder.DropIndex(
                name: "IX_Exams_UserId",
                table: "Exams");

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
                name: "LessonId",
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
                name: "LessonId",
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
                name: "LessonId",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropColumn(
                name: "LessonId",
                table: "Sentences");

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
                name: "LessonId",
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
                name: "Grade",
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
                name: "UserId",
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

            migrationBuilder.RenameColumn(
                name: "EnglishSentence",
                table: "Words",
                newName: "TurkishWord");

            migrationBuilder.RenameColumn(
                name: "EnglishSentence",
                table: "SentenceTranslationQuestions",
                newName: "Sentence");

            migrationBuilder.RenameColumn(
                name: "LessonId",
                table: "Exams",
                newName: "SectionId");

            migrationBuilder.RenameIndex(
                name: "IX_Exams_LessonId",
                table: "Exams",
                newName: "IX_Exams_SectionId");

            migrationBuilder.RenameColumn(
                name: "LessonId",
                table: "Comments",
                newName: "SectionId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_LessonId",
                table: "Comments",
                newName: "IX_Comments_SectionId");

            migrationBuilder.AddColumn<int>(
                name: "ExamId",
                table: "WordTranslationQuestions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "WordTranslationQuestions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnglishWord",
                table: "Words",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CorrectOption",
                table: "SentenceTranslationQuestions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExamId",
                table: "SentenceTranslationQuestions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OptionA",
                table: "SentenceTranslationQuestions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OptionB",
                table: "SentenceTranslationQuestions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OptionC",
                table: "SentenceTranslationQuestions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OptionD",
                table: "SentenceTranslationQuestions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "SentenceTranslationQuestions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExamId",
                table: "InfillQuestions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "InfillQuestions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    LanguageLevel = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WordTranslationQuestions_ExamId",
                table: "WordTranslationQuestions",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_WordTranslationQuestions_SectionId",
                table: "WordTranslationQuestions",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_SentenceTranslationQuestions_ExamId",
                table: "SentenceTranslationQuestions",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_SentenceTranslationQuestions_SectionId",
                table: "SentenceTranslationQuestions",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_InfillQuestions_ExamId",
                table: "InfillQuestions",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_InfillQuestions_SectionId",
                table: "InfillQuestions",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_LessonId",
                table: "Sections",
                column: "LessonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Sections_SectionId",
                table: "Comments",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Sections_SectionId",
                table: "Exams",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InfillQuestions_Exams_ExamId",
                table: "InfillQuestions",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InfillQuestions_Sections_SectionId",
                table: "InfillQuestions",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SentenceTranslationQuestions_Exams_ExamId",
                table: "SentenceTranslationQuestions",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SentenceTranslationQuestions_Sections_SectionId",
                table: "SentenceTranslationQuestions",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WordTranslationQuestions_Exams_ExamId",
                table: "WordTranslationQuestions",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WordTranslationQuestions_Sections_SectionId",
                table: "WordTranslationQuestions",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id");
        }
    }
}
