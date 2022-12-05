using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using LanguageLearning.Authorization.Users;
using LanguageLearning.Domain.Questions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanguageLearning.Domain
{
    public class Lesson : FullAuditedEntity
    {
        public string Name { get; set; }

        [ForeignKey("LanguageId")]
        public Language Language { get; set; }
        public int LanguageId { get; set; }
        public List<GramerQuestion> GramerQuestions { get; set; }
        public List<ListeningQuestion> ListeningQuestions { get; set; }
        public List<VocabularyQuestion> VocabularyQuestions { get; set; }
        public List<WritingQuestion> WritingQuestions { get; set; }
        public List<SpeakingQuestion> SpeakingQuestions { get; set; }
        public List<Comment> Comments { get; set; }
        public Exam Exam { get; set; }
        public List<User> Users { get; set; }

    }
}
