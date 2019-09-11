using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DylanTodo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DylanTodo.Controllers
{
    public class IntroductionController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            if (!HttpContext.Request.Cookies.ContainsKey("userinfo"))
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
        }
        [HttpPost]
        public IActionResult SetName(TodoUser user)
        {
            var todolist = new TodoList(user);
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(todolist);
            HttpContext.Response.Cookies.Append("userinfo", jsonString);
            return RedirectToAction("Index","Home", new { area = ""});
        }

    }
}
