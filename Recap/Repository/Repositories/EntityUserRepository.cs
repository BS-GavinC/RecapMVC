using Recap.Models;
using Recap.Models.Context;
using Recap.Repository.Interfaces;

namespace Recap.Repository.Repositories
{
    public class EntityUserRepository : IUserRepository
    {

        private readonly MyDbContext _context;

        public EntityUserRepository(MyDbContext context)
        {
            _context = context;
        }


        public User? Create(User user)
        {

            try
            {
                _context.Add(user);
                _context.SaveChanges();
                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            

        }

        public bool Delete(User user)
        {
            try
            {
                _context.Remove(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public IEnumerable<User> Get()
        {
            return _context.users.ToList();
        }

        public User? GetByEmail(string email)
        {
            User? user = _context.users.First(x => x.Email == email);
            return user is not null ? user : null;
        }

        public User? GetById(int id)
        {
            //_context.users.Find(u => u.id == id);
            User? user = _context.users.Find(id);
            return user is not null ? user : null;
        }

        public User? Update(User user)
        {
            try
            {
                _context.Update(user);
                _context.SaveChanges();
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
