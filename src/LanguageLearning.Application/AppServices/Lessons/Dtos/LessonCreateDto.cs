﻿using Abp.AutoMapper;
using LanguageLearning.Domain;

namespace LanguageLearning.AppServices.Lessons.Dtos
{
    public class LessonCreateDto
    {
        public string Name { get; set; }
        public int LanguageId { get; set; }
    }
}
