using System.Diagnostics;
using ItemSelectorApp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ItemSelectorApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var items = new List<Item>
            {
                new Item { Name = "Oranges", ImageUrl = "/fruits/oranges.jpeg", Price = 100 },
                new Item { Name = "Grapes", ImageUrl = "/fruits/grapes.jpeg", Price = 50 },
                new Item { Name = "Bananas", ImageUrl = "/fruits/bananas.jpg", Price = 30 }
            };

            var viewModel = new ItemViewModel
            {
                Items = items
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
