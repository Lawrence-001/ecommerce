using System.ComponentModel.DataAnnotations;

namespace e_commerce.ViewModels
{
    public class LoginVm
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
