namespace LanguageLearning.AppServices.Lessons.Dtos
{
    public class LessonGetAllByUserAndByLanguageOutputDto
    {
        public string LessonName { get; set; }
        public int LessonId { get; set; }
        public bool IsPass { get; set; }
    }
}
