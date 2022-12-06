using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Exams.Dtos
{
    public class ExamGetResultDto : EntityDto
    {
        public int LessonId { get; set; }
        public int Grade { get; set; }
        public bool IsPassed { get; set; }
    }
}
