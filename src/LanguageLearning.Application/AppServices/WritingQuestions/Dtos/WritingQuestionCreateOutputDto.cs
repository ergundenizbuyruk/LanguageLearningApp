using Abp.Application.Services.Dto;

namespace LanguageLearning.AppServices.WritingQuestions.Dtos
{
    public class WritingQuestionCreateOutputDto : EntityDto
    {
        public int LessonId { get; set; }
        public string TurkishSentence { get; set; }
        public string EnglishSentence { get; set; }
    }
}
