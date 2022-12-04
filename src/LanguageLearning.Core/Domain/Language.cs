using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using LanguageLearning.Authorization.Users;
using System.Collections.Generic;

namespace LanguageLearning.Domain
{
    public class Language : FullAuditedEntity
    {
        public string Name { get; set; }
        public List<Lesson> Lessons { get; set; }
        public List<User> Users { get; set; }

    }
}
