using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanguageLearning.Domain
{
    public class Lesson : Entity
    {
        public string Name { get; set; }
        public List<Section> Sections { get; set; }

        [ForeignKey("LanguageId")]
        public Language Language { get; set; }
        public int LanguageId { get; set; }
    }
}
