using Abp.Domain.Entities.Auditing;
using LanguageLearning.Authorization.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanguageLearning.Domain
{
    public class Exam : FullAuditedEntity
    {
        [ForeignKey("LessonId")]
        public Lesson Lesson { get; set; }
        public int LessonId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public long UserId { get; set; }
        public int Grade { get; set; }
    }
}
