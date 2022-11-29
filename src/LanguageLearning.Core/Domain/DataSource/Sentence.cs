using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace LanguageLearning.Domain.DataSource
{
    public class Sentence : Entity, IStringQuestion
    {
        public string TurkishSentence { get; set; }
        public string EnglishSentence { get; set; }
    }
}
