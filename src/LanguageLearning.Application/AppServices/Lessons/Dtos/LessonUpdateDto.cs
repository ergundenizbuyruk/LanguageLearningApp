using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LanguageLearning.Domain;

namespace LanguageLearning.AppServices.Lessons.Dtos
{
    public class LessonUpdateDto : EntityDto
    {
        public string Name { get; set; }
    }
}
