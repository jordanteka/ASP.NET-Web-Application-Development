using FeedBackForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace FeedBackForm.Controllers
{
    public class FeedBackController : Controller
    {
        public IActionResult Submit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(FeedBack model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Feedback submitted successfully!";
                return View(model);
            }

            return View(model);
        }
    }
}
