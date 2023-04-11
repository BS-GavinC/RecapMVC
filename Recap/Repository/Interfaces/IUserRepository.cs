using Recap.Models.DTO;
using Recap.Models;

namespace Recap.Repository.Interfaces
{
    public interface IUserRepository
    {

        User? Create(User user);

        IEnumerable<User> Get();

        User? GetById(int id);

        User? Update(User user);

        bool Delete(User user);

        User? GetByEmail(string email);
    }
}
