using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Recap.Models.DTO
{
    public class UserChangePasswordDTO
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Ce champ est requis")]
        [DisplayName("Mot de passe actuel")]
        public string ActualPassword { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Nouveau mot de passe")]
        [Required(ErrorMessage = "Ce champ est requis")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!]).{8,25}$",
            ErrorMessage = "Le mot de passe doit contenir de 8 à 25 caracteres, en comprenant au moins une minuscule, une majuscule, un nombre et un caractere special, bien cordialement. ")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Confirmation du nouveau mot de passe")]
        [Required(ErrorMessage = "Ce champ est requis")]
        [Compare("NewPassword", ErrorMessage = "Ne correspond pas au champ 'Password'")]
        public string ConfirmNewPassword { get; set;}

    }
}
