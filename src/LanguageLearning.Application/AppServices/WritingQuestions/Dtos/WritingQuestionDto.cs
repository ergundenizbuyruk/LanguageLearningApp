using Abp.AutoMapper;
using LanguageLearning.Domain.Questions;

namespace LanguageLearning.AppServices.WritingQuestions.Dtos
{
    [AutoMapFrom(typeof(WritingQuestion))]
    public class WritingQuestionDto
    {
        public string TurkishSentence { get; set; }
        public string EnglishSentence { get; set; }
    }
}
