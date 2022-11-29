using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using LanguageLearning.Authorization.Users;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanguageLearning.Domain
{
    public class Comment : Entity
    {
        public long UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public string Content { get; set; }

        [Range(1, 5)]
        public int Rate { get; set; }

        [ForeignKey("SectionId")]
        public Section Section { get; set; }
        public int SectionId { get; set; }
    }
}
