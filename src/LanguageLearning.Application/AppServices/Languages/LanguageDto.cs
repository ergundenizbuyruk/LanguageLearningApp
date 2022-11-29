using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LanguageLearning.Authorization.Users;
using LanguageLearning.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Languages
{
    [AutoMap(typeof(Language))]
    public class LanguageDto : EntityDto
    {
        public string Name { get; set; }
        public List<Lesson> Lessons { get; set; }
        public List<User> Users { get; set; }
    }
}
