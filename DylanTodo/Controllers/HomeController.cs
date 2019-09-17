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
            _todoList = TodoList.ReturnTodoList(jsonString);
            return View(_todoList);
        }
        [HttpPost]
        public IActionResult AddTodo(TodoList e)
        {
            var newTodo = new TodoItem(e.newTodo.Description);
            var jsonString = HttpContext.Request.Cookies["userinfo"];
            jsonString = TodoList.AddTodoItem(jsonString, newTodo);

            UpdateCookie(jsonString);

            return RedirectToAction("Index", "Home", new { area = "" });
        }
        [HttpPost]
        public IActionResult UpdateTodo(TodoList e)
        {
            var updatedTodo = new TodoItem(e.newTodo.Description, e.newTodo.Id);
            var jsonString = HttpContext.Request.Cookies["userinfo"];
            jsonString = TodoList.UpdateTodo(jsonString, updatedTodo);
            UpdateCookie(jsonString);

            return NoContent();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void UpdateCookie(string jsonstring)
        {
            var option = new CookieOptions();
            option.Expires = DateTime.Now.AddYears(1);
            Response.Cookies.Append("userinfo", jsonstring, option);
        }
    }
}
