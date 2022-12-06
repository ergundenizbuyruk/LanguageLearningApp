using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Comments.Dtos
{
    public class CommentCreateOutputDto : EntityDto
    {
        public string Content { get; set; }
        public int Rate { get; set; }
        public int LessonId { get; set; }
    }
}

