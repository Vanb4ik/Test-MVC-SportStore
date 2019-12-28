using System.ComponentModel.DataAnnotations;

namespace SportStorage.Models.ViewModels
{
    public class LoginModel
    {
        [Required]
        public string Type { get; set; }
        
        [Required]
        [UIHint("password")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; } = "/";
    }
}