using FormValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormValidation.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                // Normally you'd save to the DB here.
                ViewBag.Message = "Registration successful!";
                return View(user);
            }

            return View(user);
        }
        }
}
