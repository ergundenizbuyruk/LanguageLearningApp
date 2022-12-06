using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System.Collections.Generic;

namespace LanguageLearning.Domain
{
    public class Language : FullAuditedEntity
    {
        public string Name { get; set; }
        public List<Lesson> Lessons { get; set; }

    }
}
