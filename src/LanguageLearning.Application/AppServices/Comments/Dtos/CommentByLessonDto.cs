using Abp.AutoMapper;
using LanguageLearning.Domain;
using LanguageLearning.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Comments.Dtos
{
    [AutoMapFrom(typeof(Comment))]
    [AutoMapTo(typeof(Comment))]
    public class CommentByLessonDto
    {
        public UserDto User{ get; set; }
        public string Content { get; set; }
        public int Rate { get; set; }
    }
}
