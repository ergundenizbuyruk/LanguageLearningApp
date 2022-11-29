using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LanguageLearning.Domain;
using LanguageLearning.Domain.Questions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Sections
{
    [AutoMap(typeof(Section))]
    public class SectionDto : EntityDto
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
