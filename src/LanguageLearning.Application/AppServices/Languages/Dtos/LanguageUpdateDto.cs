using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LanguageLearning.Domain;

namespace LanguageLearning.AppServices.Languages.Dtos
{
    [AutoMapTo(typeof(Language))]
    public class LanguageUpdateDto : EntityDto
    {
        public string Name { get; set; }
    }
}
