using Abp.AutoMapper;
using LanguageLearning.Domain.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.WritingQuestions.Dtos
{
    [AutoMap(typeof(WritingQuestion))]
    public class WritingQuestionCreateDto
    {
        public int LessonId { get; set; }
        public string TurkishSentence { get; set; }
        public string EnglishSentence { get; set; }
    }
}
