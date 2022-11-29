using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace LanguageLearning.Domain.DataSource
{
    public class Word : Entity, IStringQuestion
    {
        public string TurkishWord { get; set; }
        public string EnglishWord { get; set; }
    }
}
