﻿using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace LanguageLearning.Domain.Questions
{
    public class InfillQuestion : Entity
    {
        public string Sentence { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectOption { get; set; }
    }
}