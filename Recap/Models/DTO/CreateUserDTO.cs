using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Recap.Models.DTO
{
    public class CreateUserDTO
    {
        [Required(ErrorMessage = "Ce champ est requis")]
        public string Firstname { get; set; }


        [Required(ErrorMessage = "Ce champ est requis")]
        public string Lastname { get; set; }


        [Required(ErrorMessage = "Ce champ est requis")]
        [EmailAddress(ErrorMessage = "Entrez un email valide")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ce champ est requis")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!]).{8,25}$", 
            ErrorMessage = "Le mot de passe doit contenir de 8 à 25 caracteres, en comprenant au moins une minuscule, une majuscule, un nombre et un caractere special, bien cordialement. ")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Ce champ est requis")]
        [Compare("Password", ErrorMessage = "Ne correspond pas au champ 'Password'")]
        public string PasswordConfirmation { get; set; }
    }
}
