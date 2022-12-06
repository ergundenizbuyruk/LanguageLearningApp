using Abp.Application.Services.Dto;

namespace LanguageLearning.AppServices.ListeningQuestions.Dtos
{
    public class ListeningQuestionUpdateDto : EntityDto
    {
        public string EnglishSentence { get; set; }
    }
}
