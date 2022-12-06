namespace LanguageLearning.AppServices.Exams.Dtos
{
    public class ExamCreateOutputDto
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public long UserId { get; set; }
        public int Grade { get; set; }
    }
}
