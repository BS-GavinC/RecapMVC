using Microsoft.AspNetCore.Mvc;
using Recap.Models;
using Recap.Models.DTO;
using Recap.Models.Mapper;
using Recap.Repository.Interfaces;
using Recap.Services.Interfaces;

namespace Recap.Services.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User? Create(CreateUserDTO user)
        {
            return _userRepository.Create(user.ToUser());
        }

        public bool Delete(int id)
        {
            User user = _userRepository.GetById(id);
            return _userRepository.Delete(user);
        }

        public IEnumerable<User> Get()
        {
            return _userRepository.Get();
        }

        public User GetById(int id)
        {
            
            return _userRepository.GetById(id);
        }

        

        public User? Update(int id, UpdateUserDTO user)
        {
            User userToModify = _userRepository.GetById(id);
            userToModify.Firstname = user.Firstname;
            userToModify.Lastname = user.Lastname;
            userToModify.Email = user.Email;
            return _userRepository.Update(userToModify);
        }

        public bool PasswordIsValid(int id, string password)
        {
            User user = _userRepository.GetById(id);
            return user.Password == password;
        }

        public bool UpdatePassword(int id, string newPassword)
        {
            User user = _userRepository.GetById(id);
            user.Password = newPassword;
            return _userRepository.Update(user) is not null;
        }

        public bool Connection(string email, string password)
        {
            User user = _userRepository.GetByEmail(email);

            return user != null && user.Password == password;
        }
    }
}
