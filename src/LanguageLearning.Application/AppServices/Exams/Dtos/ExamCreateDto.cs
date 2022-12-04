namespace LanguageLearning.AppServices.Exams.Dtos
{
    public class ExamCreateDto
    {
        public int LessonId { get; set; }
        public int UserId { get; set; }
        public int Grade { get; set; }
    }
}
