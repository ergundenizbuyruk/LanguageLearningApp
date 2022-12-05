using Abp.Zero.EntityFrameworkCore;
using LanguageLearning.Authorization.Roles;
using LanguageLearning.Authorization.Users;
using LanguageLearning.Domain;
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
        public DbSet<WritingQuestion> Sentences { get; set; }
        public DbSet<SpeakingQuestion> Words { get; set; }
        public DbSet<GramerQuestion> InfillQuestions { get; set; }
        public DbSet<ListeningQuestion> SentenceTranslationQuestions { get; set; }
        public DbSet<VocabularyQuestion> WordTranslationQuestions { get; set; }
        public DbSet<UserCurrentLesson> UserCurrentLessons { get; set; }
        public LanguageLearningDbContext(DbContextOptions<LanguageLearningDbContext> options)
            : base(options)
        {
        }
    }
}
