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

namespace LanguageLearning.AppServices.Lessons.Dtos
{
    [AutoMap(typeof(Lesson))]
    public class LessonUpdateDto : EntityDto
    {
        public string Name { get; set; }
    }
}
