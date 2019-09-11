using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DylanTodo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            HttpContext.Response.Cookies.Append("userinfo", user.UserName);
            return RedirectToAction("Index","Home", new { area = ""});
        }

    }
}
