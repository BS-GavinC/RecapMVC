using Microsoft.AspNetCore.Mvc;
using Recap.Models;
using Recap.Models.Context;
using Recap.Models.DTO;
using Recap.Models.Mapper;

namespace Recap.Controllers
{
    public class UserController : Controller
    {
        //Affiche tout mes users
        public IActionResult Index()
        {
            return View(FakeDb.Users);
        }

        //Affiche un user selectionné sur bas de son id
        //localhost:1234/User/Read/12 || localhost:1234/User/Read?id=12
        public IActionResult Read(int id) 
        {
            User user = FakeDb.Users.First(u => u.ID == id);
            return View(user);
        }

        // Afficher le formulaire de modification d'un user sur base de son id
        public IActionResult Update(int id)
        {
            User user = FakeDb.Users.First(u => u.ID == id);

            ViewBag.id = id;

            return View(user.toUpdateDto());
        }

        [HttpPost]
        public IActionResult Update(int id, UpdateUserDTO dto)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.id = id;
                return View(dto);
            }

            User user = FakeDb.Users.First(u => u.ID == id);
            user.Lastname = dto.Lastname;
            user.Email = dto.Email;
            user.Firstname = dto.Firstname;

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

            FakeDb.Users.Add(newUser.ToUser());
            return RedirectToAction("Index");
            
        }

        //Affiche une page de confirmation de suppression d'un user sur base de son id
        public IActionResult Delete(int id)
        {
            User user = FakeDb.Users.First(u => u.ID == id);
            return View(user);
        }

    }
}
