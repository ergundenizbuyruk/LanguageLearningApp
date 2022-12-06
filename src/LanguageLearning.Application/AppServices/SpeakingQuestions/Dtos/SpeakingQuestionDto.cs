using Abp.AutoMapper;
using LanguageLearning.Domain.Questions;

namespace LanguageLearning.AppServices.SpeakingQuestions.Dtos
{
    [AutoMapFrom(typeof(SpeakingQuestion))]
    public class SpeakingQuestionDto
    {
        public string EnglishSentence { get; set; }
    }
}
