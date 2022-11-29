using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LanguageLearning.Authorization.Users;
using LanguageLearning.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Comments
{
    [AutoMap(typeof(Comment))]
    public class CommentDto : EntityDto
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
