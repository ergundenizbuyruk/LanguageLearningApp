using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using LanguageLearning.Domain.Questions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanguageLearning.Domain
{
    public class Section : Entity
    {
        public string Name { get; set; }
        public LanguageLevel LanguageLevel { get; set; }
        public int LessonId { get; set; }

        [ForeignKey("LessonId")]
        public Lesson Lesson { get; set; }
        public List<InfillQuestion> InfillQuestions { get; set; }
        public List<SentenceTranslationQuestion> SentenceTranslationQuestions { get; set; }
        public List<WordTranslationQuestion> WordTranslationsQuestions { get; set; }
        public List<Comment> Comments { get; set; }
        public Exam Exam { get; set; }
    }
}
