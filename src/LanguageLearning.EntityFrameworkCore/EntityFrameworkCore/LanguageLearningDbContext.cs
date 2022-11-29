using Abp.Zero.EntityFrameworkCore;
using LanguageLearning.Authorization.Roles;
using LanguageLearning.Authorization.Users;
using LanguageLearning.Domain;
using LanguageLearning.Domain.DataSource;
using LanguageLearning.Domain.Questions;
using LanguageLearning.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace LanguageLearning.EntityFrameworkCore
{
    public class LanguageLearningDbContext : AbpZeroDbContext<Tenant, Role, User, LanguageLearningDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Sentence> Sentences { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<InfillQuestion> InfillQuestions { get; set; }
        public DbSet<SentenceTranslationQuestion> SentenceTranslationQuestions { get; set; }
        public DbSet<WordTranslationQuestion> WordTranslationQuestions { get; set; }
        public LanguageLearningDbContext(DbContextOptions<LanguageLearningDbContext> options)
            : base(options)
        {
        }
    }
}
