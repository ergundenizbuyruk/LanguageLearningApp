using System.ComponentModel.DataAnnotations;

namespace LanguageLearning.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}