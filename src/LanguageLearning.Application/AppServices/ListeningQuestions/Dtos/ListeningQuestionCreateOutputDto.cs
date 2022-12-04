using Abp.Application.Services.Dto;

namespace LanguageLearning.AppServices.ListeningQuestions.Dtos
{
    public class ListeningQuestionCreateOutputDto : EntityDto
    {
        public int LessonId { get; set; }
        public string EnglishSentence { get; set; }
    }
}
