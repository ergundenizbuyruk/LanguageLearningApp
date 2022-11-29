using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LanguageLearning.Domain.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.SentenceTranslationQuestions
{
    [AutoMap(typeof(SentenceTranslationQuestion))]
    public class SentenceTranslationQuestionDto:EntityDto
    {
        public string Sentence { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectOption { get; set; }
    }
}
