using Abp.Domain.Entities.Auditing;
using LanguageLearning.Authorization.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanguageLearning.Domain
{
    public class UserCurrentLesson : FullAuditedEntity
    {

        [ForeignKey("UserId")]
        public User User { get; set; }
        public long UserId { get; set; }

        [ForeignKey("LessonId")]
        public Lesson Lesson { get; set; }
        public int LessonId { get; set; }
        public bool IsPassed { get; set; }

    }
}
