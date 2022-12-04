using Abp.AutoMapper;
using LanguageLearning.Domain;
using LanguageLearning.Domain.Questions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.GramerQuestions.Dtos
{
    [AutoMap(typeof(GramerQuestion))]
    public class GramerQuestionCreateDto
    {
        public int LessonId { get; set; }
        public string Sentence { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectOption { get; set; }
    }
}
