using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using LanguageLearning.Domain.Questions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanguageLearning.Domain
{
    public class Exam : Entity
    {
        [ForeignKey("SectionId")]
        public Section Section { get; set; }
        public int SectionId { get; set; }
        public List<InfillQuestion> InfillQuestions { get; set; }
        public List<SentenceTranslationQuestion> SentenceTranslationQuestions { get; set; }
        public List<WordTranslationQuestion> WordTranslationsQuestions { get; set; }

    }
}
