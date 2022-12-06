using Abp.AutoMapper;
using LanguageLearning.Domain;

namespace LanguageLearning.AppServices.Comments.Dtos
{
    [AutoMapTo(typeof(Comment))]
    public class CommentCreateDto
    {
        public string Content { get; set; }
        public int Rate { get; set; }
        public int LessonId { get; set; }
    }
}
