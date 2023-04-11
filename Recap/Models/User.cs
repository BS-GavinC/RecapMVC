using Recap.Models.Context;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recap.Models
{
    public class User
    {
        public User()
        {

        }
        public User(string firstname, string lastname, string email,  string password = "Test123=")
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
        }
        public User(string firstname, string lastname, string email, List<string>? favoriteMovie = null, string password = "Test123=")
        {

            ID = FakeDb.cpt;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            FavoriteMovie = favoriteMovie;
            Password = password;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [MaxLength(100)]
        [Required]
        public string Firstname { get; set; }

        [MaxLength(100)]
        [Required]
        public string Lastname { get; set; }

        
        [EmailAddress]
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [NotMapped]
        public List<string>? FavoriteMovie { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(100)]
        public string Password { get; set; }


    }
}
