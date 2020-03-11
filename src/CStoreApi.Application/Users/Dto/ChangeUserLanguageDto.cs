using System.ComponentModel.DataAnnotations;

namespace CStoreApi.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}