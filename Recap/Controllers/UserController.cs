using Microsoft.AspNetCore.Mvc;
using Recap.Models;
using Recap.Models.Context;
using Recap.Models.DTO;
using Recap.Models.Mapper;
using Recap.Services.Interfaces;

namespace Recap.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        //Affiche tout mes users
        public IActionResult Index()
        {
            return View(_userService.Get());
        }

        //Affiche un user selectionné sur bas de son id
        //localhost:1234/User/Read/12 || localhost:1234/User/Read?id=12
        public IActionResult Read(int id) 
        {
            
            return View(_userService.GetById(id));
        }

        // Afficher le formulaire de modification d'un user sur base de son id
        public IActionResult Update(int id)
        {
            User user = _userService.GetById(id);

            ViewBag.id = id;

            return View(user.toUpdateDto());
        }


        // User/Update?id=1
        [HttpPost]
        public IActionResult Update(int id, UpdateUserDTO dto)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.id = id;
                return View(dto);
            }

            _userService.Update(id, dto);

            return RedirectToAction("Index");

        }

        //Formulaire de creation d'utilisateur
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateUserDTO newUser)
        {
            if (!ModelState.IsValid)
            {
                return View(newUser);
            }

            _userService.Create(newUser);
            return RedirectToAction("Index");
            
        }

        //Affiche une page de confirmation de suppression d'un user sur base de son id
        public IActionResult Delete(int id)
        {
            if (_userService.Delete(id))
            {
                return RedirectToAction("Index");
            }

            return View("NotFound");
        }

        public IActionResult ChangePassword(int id)
        {
            ViewBag.id = id;
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(int id, UserChangePasswordDTO changePasswordDTO)
        {
            Console.WriteLine(id);
            if (!_userService.PasswordIsValid(id, changePasswordDTO.ActualPassword))
            {
                ModelState.AddModelError("ActualPassword", "Le mot de passe ne correspond pas.");
                return View();
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (_userService.UpdatePassword(id, changePasswordDTO.NewPassword))
            {
                return RedirectToAction("Read", new {id = id});
            }

            return View("Error");
            
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginDTO login)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if(_userService.Connection(login.Email, login.Password))
            {
               
                HttpContext.Session.SetString("Email", login.Email);
                Console.WriteLine("Is Connected");
                return RedirectToAction("Index");

            }
            ModelState.AddModelError("Email", "Email ou mot de passe invalide");
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
