using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace LanguageLearning.EntityFrameworkCore
{
    public static class LanguageLearningDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LanguageLearningDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LanguageLearningDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
