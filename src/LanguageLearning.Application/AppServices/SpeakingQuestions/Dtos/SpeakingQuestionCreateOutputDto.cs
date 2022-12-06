using Abp.Application.Services.Dto;

namespace LanguageLearning.AppServices.SpeakingQuestions.Dtos
{
    public class SpeakingQuestionCreateOutputDto : EntityDto
    {
        public int LessonId { get; set; }
        public string EnglishSentence { get; set; }
    }
}
