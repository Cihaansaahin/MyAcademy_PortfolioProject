using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı boş Geçilemez.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "şifre boş Geçilemez.")]
        public string Password { get; set; }
    }
}
