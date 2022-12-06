using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanguageLearning.Domain.Questions
{
    public class WritingQuestion : FullAuditedEntity
    {
        [ForeignKey("LessonId")]
        public Lesson Lesson { get; set; }
        public int LessonId { get; set; }
        public string TurkishSentence { get; set; }
        public string EnglishSentence { get; set; }
    }
}