using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanguageLearning.Domain.Questions
{
    public class VocabularyQuestion : FullAuditedEntity
    {
        [ForeignKey("LessonId")]
        public Lesson Lesson { get; set; }
        public int LessonId { get; set; }
        public string Word { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectOption { get; set; }
    }
}
