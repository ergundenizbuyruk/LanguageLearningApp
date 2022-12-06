using Abp.AutoMapper;
using LanguageLearning.Domain.Questions;

namespace LanguageLearning.AppServices.ListeningQuestions.Dtos
{
    [AutoMapFrom(typeof(ListeningQuestion))]
    public class ListeningQuestionDto
    {
        public string EnglishSentence { get; set; }

    }
}
