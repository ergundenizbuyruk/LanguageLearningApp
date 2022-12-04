using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LanguageLearning.Authorization.Users;
using LanguageLearning.Domain;
using System.Collections.Generic;

namespace LanguageLearning.AppServices.Languages.Dtos
{
    [AutoMap(typeof(Language))]
    public class LanguageDto : EntityDto
    {
        public string Name { get; set; }
        public List<Lesson> Lessons { get; set; }
        public List<User> Users { get; set; }
    }
}
