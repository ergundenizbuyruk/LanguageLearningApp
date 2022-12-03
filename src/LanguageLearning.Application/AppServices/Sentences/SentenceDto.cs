using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LanguageLearning.Domain.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Sentences
{
    [AutoMap(typeof(Sentence))]
    public class SentenceDto : EntityDto
    {
        public string TurkishSentence { get; set; }
        public string EnglishSentence { get; set; }
    }
}
