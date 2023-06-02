using System.ComponentModel.DataAnnotations;

namespace Hue_Festival.Models
{
    public class UserLoginRequest
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required, MinLength(6, ErrorMessage = "Mật khẩu phải có ít nhất 6 kí tự !")]
        public string Password { get; set; } = string.Empty;
    }
}
