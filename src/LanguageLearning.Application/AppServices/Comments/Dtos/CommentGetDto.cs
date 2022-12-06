using Abp.AutoMapper;
using LanguageLearning.Domain;
using LanguageLearning.Users.Dto;

namespace LanguageLearning.AppServices.Comments.Dtos
{
    [AutoMapFrom(typeof(Comment))]
    public class CommentGetDto
    {
        public UserDto User { get; set; }
        public string Content { get; set; }
        public int Rate { get; set; }
    }
}
