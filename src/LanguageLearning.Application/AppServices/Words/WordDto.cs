using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LanguageLearning.Domain.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Words
{
    [AutoMap(typeof(Word))]
    public class WordDto:EntityDto
    {
        public string TurkishWord { get; set; }
        public string EnglishWord { get; set; }
    }
}
