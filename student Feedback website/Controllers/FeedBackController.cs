using Microsoft.AspNetCore.Mvc;
using CustomerFeedBackWebsite.Models;

namespace CustomerFeedBackWebsite.Controllers
{
    public class FeedBackController : Controller
    {
        private static List<FeedBack> feedbackList = new List<FeedBack>();
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FeedBack feedback)
        {
            feedbackList.Add(feedback);
            ViewBag.Message = "Feedback submitted successfully";
            return View();
        }
        public IActionResult List()
        {
            return View(feedbackList);
        }
    }
    }
