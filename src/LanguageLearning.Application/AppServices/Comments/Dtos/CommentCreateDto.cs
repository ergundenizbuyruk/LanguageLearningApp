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

namespace LanguageLearning.AppServices.Comments.Dtos
{
    [AutoMap(typeof(Comment))]
    public class CommentCreateDto
    {
        public int UserId { get; set; }
        public string Content { get; set; }
        public int Rate { get; set; }
        public int SectionId { get; set; }
    }
}
