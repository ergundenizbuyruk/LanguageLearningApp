using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LanguageLearning.Authorization.Users;
using LanguageLearning.Domain;

namespace LanguageLearning.AppServices.Comments.Dtos
{
    [AutoMap(typeof(Comment))]
    public class CommentDto : EntityDto
    {
        public Lesson Lesson { get; set; }
        public User User { get; set; }
        public string Content { get; set; }
        public int Rate { get; set; }
    }
}
