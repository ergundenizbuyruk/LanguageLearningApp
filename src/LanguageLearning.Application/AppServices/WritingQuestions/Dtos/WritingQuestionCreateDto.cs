namespace LanguageLearning.AppServices.WritingQuestions.Dtos
{
    public class WritingQuestionCreateDto
    {
        public int LessonId { get; set; }
        public string TurkishSentence { get; set; }
        public string EnglishSentence { get; set; }
    }
}
