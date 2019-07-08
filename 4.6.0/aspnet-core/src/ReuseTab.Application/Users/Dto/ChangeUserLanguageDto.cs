using System.ComponentModel.DataAnnotations;

namespace ReuseTab.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}