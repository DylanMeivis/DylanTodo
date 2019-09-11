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
        public IActionResult Index()
        {
            if (!HttpContext.Request.Cookies.ContainsKey("userinfo"))
            {
                return RedirectToAction("Index", "Introduction", new { area = ""});
            }
            var jsonString = HttpContext.Request.Cookies["userinfo"];
            var model = Newtonsoft.Json.JsonConvert.DeserializeObject<TodoList>(HttpContext.Request.Cookies["userinfo"]);
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
