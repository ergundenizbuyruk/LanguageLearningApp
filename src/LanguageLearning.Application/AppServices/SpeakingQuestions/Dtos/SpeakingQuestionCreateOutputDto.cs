﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LanguageLearning.Domain.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.SpeakingQuestions.Dtos
{
    public class SpeakingQuestionCreateOutputDto : EntityDto
    {
        public int LessonId { get; set; }
        public string EnglishSentence { get; set; }
    }
}
