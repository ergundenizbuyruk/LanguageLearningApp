using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LanguageLearning.AppServices.Lessons.Dtos;
using LanguageLearning.Domain;
using LanguageLearning.Users.Dto;

namespace LanguageLearning.AppServices.Comments.Dtos
{
    [AutoMapFrom(typeof(Comment))]
    public class CommentDto : EntityDto
    {
        public LessonWithAllQuestionsDto Lesson { get; set; }
        public UserDto User { get; set; }
        public string Content { get; set; }
        public int Rate { get; set; }
    }
}
