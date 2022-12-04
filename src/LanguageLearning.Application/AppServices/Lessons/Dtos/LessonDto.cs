using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LanguageLearning.Domain;
using LanguageLearning.Domain.Questions;
using System.Collections.Generic;

namespace LanguageLearning.AppServices.Lessons.Dtos
{
    [AutoMap(typeof(Lesson))]
    public class LessonDto : EntityDto
    {
        public string Name { get; set; }
        public List<GramerQuestion> GramerQuestions { get; set; }
        public List<ListeningQuestion> ListeningQuestions { get; set; }
        public List<VocabularyQuestion> VocabularyQuestions { get; set; }
        public List<WritingQuestion> WritingQuestions { get; set; }
        public List<SpeakingQuestion> SpeakingQuestions { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
