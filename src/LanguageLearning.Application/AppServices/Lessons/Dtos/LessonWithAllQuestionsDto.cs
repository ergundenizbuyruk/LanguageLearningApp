﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LanguageLearning.AppServices.Comments.Dtos;
using LanguageLearning.AppServices.GramerQuestions.Dtos;
using LanguageLearning.AppServices.ListeningQuestions.Dtos;
using LanguageLearning.AppServices.SpeakingQuestions.Dtos;
using LanguageLearning.AppServices.VocabularyQuestions.Dtos;
using LanguageLearning.AppServices.WritingQuestions.Dtos;
using LanguageLearning.Domain;
using System.Collections.Generic;

namespace LanguageLearning.AppServices.Lessons.Dtos
{
    [AutoMapFrom(typeof(Lesson))]
    public class LessonWithAllQuestionsDto : EntityDto
    {
        public string Name { get; set; }
        public List<GramerQuestionDto> GramerQuestions { get; set; } = new List<GramerQuestionDto>();
        public List<ListeningQuestionDto> ListeningQuestions { get; set; } = new List<ListeningQuestionDto>();
        public List<VocabularyQuestionDto> VocabularyQuestions { get; set; } = new List<VocabularyQuestionDto>();
        public List<WritingQuestionDto> WritingQuestions { get; set; } = new List<WritingQuestionDto>();
        public List<SpeakingQuestionDto> SpeakingQuestions { get; set; } = new List<SpeakingQuestionDto>();
        public List<CommentGetDto> Comments { get; set; }
    }
}
