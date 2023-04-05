using System.ComponentModel.DataAnnotations;

namespace Recap.Models.DTO
{
    public class UpdateUserDTO
    {
        public UpdateUserDTO()
        {
            
        }

        public UpdateUserDTO(string firstname, string lastname, string email)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
        }

        [Required(ErrorMessage = "Ce champ est requis")]
        public string Firstname { get; set; }


        [Required(ErrorMessage = "Ce champ est requis")]
        public string Lastname { get; set; }


        [Required(ErrorMessage = "Ce champ est requis")]
        [EmailAddress(ErrorMessage = "Entrez un email valide")]
        public string Email { get; set; }

    }
}
