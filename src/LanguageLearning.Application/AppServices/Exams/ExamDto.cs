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

namespace LanguageLearning.AppServices.Exams
{
    [AutoMap(typeof(Exam))]
    public class ExamDto : EntityDto
    {
        [ForeignKey("SectionId")]
        public Section Section { get; set; }
        public int SectionId { get; set; }
        public List<InfillQuestion> InfillQuestions { get; set; }
        public List<SentenceTranslationQuestion> SentenceTranslationQuestions { get; set; }
        public List<WordTranslationQuestion> WordTranslationsQuestions { get; set; }
    }
}
