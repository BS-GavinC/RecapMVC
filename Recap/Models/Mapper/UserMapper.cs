using Recap.Models.Context;
using Recap.Models.DTO;

namespace Recap.Models.Mapper
{
    public static class UserMapper
    {

        // mapper mon objet CreateUserDTO to User

        public static User ToUser(this CreateUserDTO newUser)
        {
            return new User(FakeDb.Users.Last().ID + 1, newUser.Firstname, newUser.Lastname, newUser.Email, null, newUser.Password);
        }

    }
}
