using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace LanguageLearning.Domain.DataSource
{
    public class Sentence : FullAuditedEntity, IStringQuestion
    {
        public string TurkishSentence { get; set; }
        public string EnglishSentence { get; set; }
    }
}
