using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Recap.Models.DTO
{
    public class LoginDTO
    {
        [Required]
        [EmailAddress]
        [DisplayName("Email")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Ce champ est requis")]
        [DisplayName("Mot de passe")]
        public string Password { get; set; }
    }
}
