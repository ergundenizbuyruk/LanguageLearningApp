using Abp.AutoMapper;
using LanguageLearning.Domain;

namespace LanguageLearning.AppServices.Exams.Dtos
{
    [AutoMap(typeof(Exam))]
    public class ExamCreateOutputDto
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public long UserId { get; set; }
        public int Grade { get; set; }
    }
}
