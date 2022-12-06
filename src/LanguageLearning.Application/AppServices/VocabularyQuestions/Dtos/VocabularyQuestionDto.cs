using Abp.AutoMapper;
using LanguageLearning.Domain.Questions;

namespace LanguageLearning.AppServices.VocabularyQuestions.Dtos
{
    [AutoMapFrom(typeof(VocabularyQuestion))]
    public class VocabularyQuestionDto
    {
        public string Word { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectOption { get; set; }
    }
}
