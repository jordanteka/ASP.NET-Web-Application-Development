using Microsoft.AspNetCore.Mvc;
using ItemSelectorApp.Models;

namespace ItemSelectorApp.Controllers
{
    public class SelectController : Controller
    {
        public IActionResult Index()
        {
            var items =new List<Item>
            {
                new Item { Name = "Oranges",ImageUrl="/fruits/oranges.jpeg",Price=100 },
                new Item { Name = "Grapes", ImageUrl = "/fruits/grapes.jpeg", Price = 100 },
                new Item { Name = "Oranges", ImageUrl = "/fruits/Bananas.jpeg", Price = 100 }
            };

            var viewModel = new ItemViewModel
            {
                Items = items
            };

            if (viewModel == null || viewModel.Items == null)
            {
                return Content("Model is NULL"); // For debugging
            }
            return View(viewModel);

        }
    }
}
