using Microsoft.AspNetCore.Mvc;
using Recap.Models;

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
            return View(user);
        }

        //Formulaire de creation d'utilisateur
        public IActionResult Create()
        {
            return View();
        }

        //Affiche une page de confirmation de suppression d'un user sur base de son id
        public IActionResult Delete(int id)
        {
            User user = FakeDb.Users.First(u => u.ID == id);
            return View(user);
        }

    }
}
