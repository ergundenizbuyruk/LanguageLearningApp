using Abp.AutoMapper;
using LanguageLearning.Domain;

namespace LanguageLearning.AppServices.Lessons.Dtos
{
    [AutoMap(typeof(Lesson))]
    public class LessonCreateDto
    {
        public string Name { get; set; }
    }
}
