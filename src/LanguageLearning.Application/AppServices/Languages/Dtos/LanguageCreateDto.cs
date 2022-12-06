using Abp.AutoMapper;
using LanguageLearning.Domain;

namespace LanguageLearning.AppServices.Languages.Dtos
{
    [AutoMapTo(typeof(Language))]
    public class LanguageCreateDto
    {
        public string Name { get; set; }
    }
}
