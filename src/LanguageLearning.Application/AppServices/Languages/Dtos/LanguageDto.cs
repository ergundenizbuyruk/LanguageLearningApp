using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LanguageLearning.Domain;

namespace LanguageLearning.AppServices.Languages.Dtos
{
    [AutoMapFrom(typeof(Language))]
    public class LanguageDto : EntityDto
    {
        public string Name { get; set; }
    }
}
