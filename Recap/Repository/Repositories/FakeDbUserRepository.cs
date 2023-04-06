using Recap.Models;
using Recap.Models.Context;
using Recap.Repository.Interfaces;

namespace Recap.Repository.Repositories
{
    public class FakeDbUserRepository : IUserRepository
    {
        public User? Create(User user)
        {
            try
            {
                FakeDb.Users.Add(user);
                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine( e );
                return null;
            }

        }

        public bool Delete(User user)
        {
            return FakeDb.Users.Remove(user);
        }

        public IEnumerable<User> Get()
        {
            return FakeDb.Users;
        }

        public User? GetByEmail(string email)
        {
            return FakeDb.Users.Find(x => x.Email == email);
        }

        public User GetById(int id)
        {
            return FakeDb.Users.First(u => u.ID == id);
        }

        public User? Update(User user)
        {
            try
            {
                User userToUpdate = FakeDb.Users.First(u => u.ID == user.ID);
                FakeDb.Users.Remove(userToUpdate);
                FakeDb.Users.Add(user);
                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
