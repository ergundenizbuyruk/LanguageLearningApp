using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LanguageLearning.Authorization.Users;
using LanguageLearning.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Languages.Dtos
{
    [AutoMap(typeof(Language))]
    public class LanguageUpdateDto : EntityDto
    {
        public string Name { get; set; }
    }
}
