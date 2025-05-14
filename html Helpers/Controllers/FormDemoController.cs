using htmlhelpers.Models;
using Microsoft.AspNetCore.Mvc;

namespace htmlhelpers.Controllers
{
    public class FormDemoController : Controller
    {
        public IActionResult ShowForm()
        {
            ViewBag.CountryList = new List<string> { "Nigeria", "Kenya", "USA", "UK" };
            ViewBag.Languages = new List<string> { "English", "French", "Swahili", "Spanish" };
            return View();
        }

        [HttpPost]
        public IActionResult ShowForm(FormDemo model)
        {
            ViewBag.CountryList = new List<string> { "Nigeria", "Kenya", "USA", "UK" };
            ViewBag.Languages = new List<string> { "English", "French", "Swahili", "Spanish" };

            if (ModelState.IsValid)
            {
                ViewBag.Message = "Form submitted successfully!";
            }

            return View(model);
        }
    }
}
