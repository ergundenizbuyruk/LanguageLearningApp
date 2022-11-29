using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using LanguageLearning.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Lessons
{
    [AutoMap(typeof(Lesson))]
    public class LessonDto : EntityDto
    {
        public string Name { get; set; }
        public List<Section> Sections { get; set; }

        [ForeignKey("LanguageId")]
        public Language Language { get; set; }
        public int LanguageId { get; set; }
    }
}
