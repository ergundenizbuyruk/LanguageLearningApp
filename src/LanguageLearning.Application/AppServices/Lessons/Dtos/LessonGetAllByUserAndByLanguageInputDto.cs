namespace LanguageLearning.AppServices.Lessons.Dtos
{
    public class LessonGetAllByUserAndByLanguageInputDto
    {
        public int LanguageId { get; set; }
        public long UserId { get; set; }
    }
}
