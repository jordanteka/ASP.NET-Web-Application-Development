using Microsoft.AspNetCore.Mvc;
using SimpleSPAApp.Models;

namespace SimpleSPAApp.Controllers
{
    public class TodoController : Controller
    {
        private static List<TodoItem> todos = new List<TodoItem>();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetAll()
        {
            return Json(todos);
        }

        [HttpPost]
        public JsonResult Add([FromBody] TodoItem item)
        {
            item.Id = todos.Count + 1;
            todos.Add(item);
            return Json(new { success = true, message = "Task added", item });
        }
    }
}
