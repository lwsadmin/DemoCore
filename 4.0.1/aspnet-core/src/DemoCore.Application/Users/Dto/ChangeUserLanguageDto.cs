using System.ComponentModel.DataAnnotations;

namespace DemoCore.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}