using Abp.AutoMapper;
using LanguageLearning.Domain.Questions;

namespace LanguageLearning.AppServices.GramerQuestions.Dtos
{
    [AutoMapFrom(typeof(GramerQuestion))]
    public class GramerQuestionDto
    {
        public string Sentence { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectOption { get; set; }
    }
}
