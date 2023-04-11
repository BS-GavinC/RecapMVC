using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Recap.Models.Context.Configs
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasIndex("Email").IsUnique();

            builder.HasData
                (
                new User
                {
                    ID = 1,
                    Firstname = "Alice",
                    Lastname = "Dupont",
                    Email = "alice.dupont@email.com",
                    Password = "Jt8L$ndm&kFq24cS",
                    FavoriteMovie = new List<string> { "La La Land", "Inception" }
                },
                new User
                {
                    ID = 2,
                    Firstname = "Bob",
                    Lastname = "Martin",
                    Email = "bob.martin@email.com",
                    Password = "5Gh#zBvKw3PxYrE",
                    FavoriteMovie = null
                },
                new User
                {
                    ID = 3,
                    Firstname = "Charlie",
                    Lastname = "Nguyen",
                    Email = "charlie.nguyen@email.com",
                    Password = "fT7#eRm2QxLz9Dy$",
                    FavoriteMovie = new List<string> { "The Shawshank Redemption" }
                },
                new User
                {
                    ID = 4,
                    Firstname = "David",
                    Lastname = "Lee",
                    Email = "david.lee@email.com",
                    Password = "V6b$UwPcNz @hM8xK",
                    FavoriteMovie = null
                },
                new User
                {
                    ID = 5,
                    Firstname = "Emma",
                    Lastname = "Garcia",
                    Email = "emma.garcia@email.com",
                    Password = "aH5%kXjL9$qBm2W",
                    FavoriteMovie = new List<string> { "The Godfather", "The Godfather: Part II", "The Dark Knight", "Schindler's List", "The Lord of the Rings: The Return of the King" }
                },
                new User
                {
                    ID = 6,
                    Firstname = "Frank",
                    Lastname = "Chen",
                    Email = "frank.chen@email.com",
                    Password = "qJ9@fM8cWu5$xLrE",
                    FavoriteMovie = null
                },
                new User
                {
                    ID = 7,
                    Firstname = "Grace",
                    Lastname = "Wong",
                    Email = "grace.wong@email.com",
                    Password = "7Km&zRb#vGy2hNj",
                    FavoriteMovie = new List<string> { "Cast Away", "Apocalypse Now", "Coktail" }
                },
                new User
                {
                    ID = 8,
                    Firstname = "Henry",
                    Lastname = "Zhang",
                    Email = "henry.zhang@email.com",
                    Password = "T4c#nSv@wGj2RkF",
                    FavoriteMovie = null
                },
                new User
                {
                    ID = 9,
                    Firstname = "Isabella",
                    Lastname = "Lopez",
                    Email = "isabella.lopez@email.com",
                    Password = "H8f$kL3q#sVp9Xy",
                    FavoriteMovie = null
                },
                new User
                {
                    ID = 10,
                    Firstname = "Jack",
                    Lastname = "Kim",
                    Email = "jack.kim@email.com",
                    Password = "3ZgY*6tLx#pVfDhN",
                    FavoriteMovie = new List<string> { "The Godfather", "The Dark Knight" }
                }
                );
        }
    }
}
