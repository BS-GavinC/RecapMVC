using Recap.Models.Context;

namespace Recap.Models
{
    public class User
    {
        public User(string firstname, string lastname, string email, List<string>? favoriteMovie = null, string password = "Test123=")
        {

            ID = FakeDb.cpt;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            FavoriteMovie = favoriteMovie;
            Password = password;
        }

        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public List<string> FavoriteMovie { get; set; }

        public string Password { get; set; }


    }
}
