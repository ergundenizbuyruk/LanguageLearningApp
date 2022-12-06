using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LanguageLearning.Domain;

namespace LanguageLearning.AppServices.Comments.Dtos
{
    [AutoMapTo(typeof(Comment))]
    public class CommentUpdateDto : EntityDto
    {
        public string Content { get; set; }
        public int Rate { get; set; }
    }
}
