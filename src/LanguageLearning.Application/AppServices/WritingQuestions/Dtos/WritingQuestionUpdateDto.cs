using Abp.Application.Services.Dto;

namespace LanguageLearning.AppServices.WritingQuestions.Dtos
{
    public class WritingQuestionUpdateDto : EntityDto
    {
        public string TurkishSentence { get; set; }
        public string EnglishSentence { get; set; }
    }
}
