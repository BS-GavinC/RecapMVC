using Recap.Models;
using Recap.Models.DTO;

namespace Recap.Services.Interfaces
{
    public interface IUserService
    {

        User? Create(CreateUserDTO user);

        IEnumerable<User> Get();

        User GetById(int id);

        User? Update(int id, UpdateUserDTO user);

        bool Delete(int id);

        bool PasswordIsValid(int id, string password);

        bool UpdatePassword(int id, string newPassword);

        bool Connection(string email, string password);

    }
}
