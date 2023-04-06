using Recap.Models.Context;
using Recap.Models.DTO;

namespace Recap.Models.Mapper
{
    public static class UserMapper
    {

        // mapper mon objet CreateUserDTO to User

        public static User ToUser(this CreateUserDTO newUser)
        {
            return new User(newUser.Firstname, newUser.Lastname, newUser.Email, null, newUser.Password);
        }

        public static UpdateUserDTO toUpdateDto(this User user)
        {
            return new UpdateUserDTO(user.Firstname, user.Lastname, user.Email);
        }

    }
}
