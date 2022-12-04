using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LanguageLearning.Domain;
using LanguageLearning.Domain.Questions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Exams.Dtos
{
    [AutoMap(typeof(Exam))]
    public class ExamCreateOutputDto
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public int UserId { get; set; }
        public int Grade { get; set; }
    }
}
