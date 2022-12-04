using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LanguageLearning.Domain.Questions;

namespace LanguageLearning.AppServices.GramerQuestions.Dtos
{
    [AutoMap(typeof(GramerQuestion))]
    public class GramerQuestionUpdateDto : EntityDto
    {
        public int LessonId { get; set; }
        public string Sentence { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectOption { get; set; }
    }
}
