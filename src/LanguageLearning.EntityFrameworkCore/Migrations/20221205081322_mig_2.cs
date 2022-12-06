using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageLearning.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_WordTranslationQuestions",
                table: "WordTranslationQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Words",
                table: "Words");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SentenceTranslationQuestions",
                table: "SentenceTranslationQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sentences",
                table: "Sentences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InfillQuestions",
                table: "InfillQuestions");

            migrationBuilder.RenameTable(
                name: "WordTranslationQuestions",
                newName: "VocabularyQuestions");

            migrationBuilder.RenameTable(
                name: "Words",
                newName: "SpeakingQuestions");

            migrationBuilder.RenameTable(
                name: "SentenceTranslationQuestions",
                newName: "ListeningQuestions");

            migrationBuilder.RenameTable(
                name: "Sentences",
                newName: "WritingQuestions");

            migrationBuilder.RenameTable(
                name: "InfillQuestions",
                newName: "GramerQuestions");

            migrationBuilder.RenameIndex(
                name: "IX_WordTranslationQuestions_LessonId",
                table: "VocabularyQuestions",
                newName: "IX_VocabularyQuestions_LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_Words_LessonId",
                table: "SpeakingQuestions",
                newName: "IX_SpeakingQuestions_LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_SentenceTranslationQuestions_LessonId",
                table: "ListeningQuestions",
                newName: "IX_ListeningQuestions_LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_Sentences_LessonId",
                table: "WritingQuestions",
                newName: "IX_WritingQuestions_LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_InfillQuestions_LessonId",
                table: "GramerQuestions",
                newName: "IX_GramerQuestions_LessonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VocabularyQuestions",
                table: "VocabularyQuestions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpeakingQuestions",
                table: "SpeakingQuestions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ListeningQuestions",
                table: "ListeningQuestions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WritingQuestions",
                table: "WritingQuestions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GramerQuestions",
                table: "GramerQuestions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GramerQuestions_Lessons_LessonId",
                table: "GramerQuestions",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListeningQuestions_Lessons_LessonId",
                table: "ListeningQuestions",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpeakingQuestions_Lessons_LessonId",
                table: "SpeakingQuestions",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VocabularyQuestions_Lessons_LessonId",
                table: "VocabularyQuestions",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WritingQuestions_Lessons_LessonId",
                table: "WritingQuestions",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GramerQuestions_Lessons_LessonId",
                table: "GramerQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_ListeningQuestions_Lessons_LessonId",
                table: "ListeningQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_SpeakingQuestions_Lessons_LessonId",
                table: "SpeakingQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_VocabularyQuestions_Lessons_LessonId",
                table: "VocabularyQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_WritingQuestions_Lessons_LessonId",
                table: "WritingQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WritingQuestions",
                table: "WritingQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VocabularyQuestions",
                table: "VocabularyQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpeakingQuestions",
                table: "SpeakingQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ListeningQuestions",
                table: "ListeningQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GramerQuestions",
                table: "GramerQuestions");

            migrationBuilder.RenameTable(
                name: "WritingQuestions",
                newName: "Sentences");

            migrationBuilder.RenameTable(
                name: "VocabularyQuestions",
                newName: "WordTranslationQuestions");

            migrationBuilder.RenameTable(
                name: "SpeakingQuestions",
                newName: "Words");

            migrationBuilder.RenameTable(
                name: "ListeningQuestions",
                newName: "SentenceTranslationQuestions");

            migrationBuilder.RenameTable(
                name: "GramerQuestions",
                newName: "InfillQuestions");

            migrationBuilder.RenameIndex(
                name: "IX_WritingQuestions_LessonId",
                table: "Sentences",
                newName: "IX_Sentences_LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_VocabularyQuestions_LessonId",
                table: "WordTranslationQuestions",
                newName: "IX_WordTranslationQuestions_LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_SpeakingQuestions_LessonId",
                table: "Words",
                newName: "IX_Words_LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_ListeningQuestions_LessonId",
                table: "SentenceTranslationQuestions",
                newName: "IX_SentenceTranslationQuestions_LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_GramerQuestions_LessonId",
                table: "InfillQuestions",
                newName: "IX_InfillQuestions_LessonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sentences",
                table: "Sentences",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WordTranslationQuestions",
                table: "WordTranslationQuestions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Words",
                table: "Words",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SentenceTranslationQuestions",
                table: "SentenceTranslationQuestions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InfillQuestions",
                table: "InfillQuestions",
                column: "Id");

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
    }
}
