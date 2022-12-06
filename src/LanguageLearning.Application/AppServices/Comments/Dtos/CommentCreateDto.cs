using Abp.AutoMapper;
using LanguageLearning.Domain;

namespace LanguageLearning.AppServices.Comments.Dtos
{
    [AutoMapFrom(typeof(Comment))]
    public class CommentCreateDto
    {
        public int UserId { get; set; }
        public string Content { get; set; }
        public int Rate { get; set; }
        public int LessonId { get; set; }
    }
}
