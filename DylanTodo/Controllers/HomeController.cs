using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DylanTodo.Models;
using Microsoft.AspNetCore.Http;

namespace DylanTodo.Controllers
{
    public class HomeController : Controller
    {
        private TodoList _todoList;
        public IActionResult Index()
        {
            if (!HttpContext.Request.Cookies.ContainsKey("userinfo"))
            {
                return RedirectToAction("Index", "Introduction", new { area = "" });
            }
            var jsonString = HttpContext.Request.Cookies["userinfo"];
            _todoList = Newtonsoft.Json.JsonConvert.DeserializeObject<TodoList>(HttpContext.Request.Cookies["userinfo"]);
            return View(_todoList);
        }
        [HttpPost]
        public IActionResult AddTodo(TodoList e)
        {
            var newTodo = new TodoItem(e.newTodo);
            _todoList.AllItems.Add(newTodo);
            return RedirectToAction("Index", "Home", new { area = "" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
