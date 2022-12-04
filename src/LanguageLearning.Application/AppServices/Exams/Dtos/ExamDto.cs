using Abp.Application.Services.Dto;
using LanguageLearning.Domain.Questions;
using System.Collections.Generic;

namespace LanguageLearning.AppServices.Exams.Dtos
{
    public class ExamDto : EntityDto
    {
        public List<GramerQuestion> GramerQuestions { get; set; } = new List<GramerQuestion>();
        public List<ListeningQuestion> ListeningQuestions { get; set; } = new List<ListeningQuestion>();
        public List<VocabularyQuestion> VocabularyQuestions { get; set; } = new List<VocabularyQuestion>();
        public List<WritingQuestion> WritingQuestions { get; set; } = new List<WritingQuestion>();
        public List<SpeakingQuestion> SpeakingQuestions { get; set; } = new List<SpeakingQuestion>();
    }
}
