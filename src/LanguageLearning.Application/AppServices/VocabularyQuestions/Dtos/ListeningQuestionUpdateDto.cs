﻿using Abp.Application.Services.Dto;

namespace LanguageLearning.AppServices.VocabularyQuestions.Dtos
{
    public class VocabularyQuestionUpdateDto : EntityDto
    {
        public string Word { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectOption { get; set; }
    }
}
