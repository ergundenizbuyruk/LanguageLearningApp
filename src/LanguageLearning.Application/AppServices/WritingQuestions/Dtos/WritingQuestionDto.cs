using Abp.AutoMapper;
using LanguageLearning.Domain.Questions;

namespace LanguageLearning.AppServices.WritingQuestions.Dtos
{
    public class WritingQuestionDto
    {
        public string TurkishSentence { get; set; }
        public string EnglishSentence { get; set; }
    }
}
