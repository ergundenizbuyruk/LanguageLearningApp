using LanguageLearning.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Lessons.Dtos
{
    public class LessonGetAllByUserDto
    {
        public Lesson Lesson { get; set; }
        public bool IsPass { get; set; }
    }
}
