namespace Recap.Models
{
    public class User
    {
        public User(int iD, string firstname, string lastname, string email, List<string>? favoriteMovie = null)
        {

            ID = iD;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            FavoriteMovie = favoriteMovie;
        }

        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public List<string> FavoriteMovie { get; set; }


    }
}
