using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DylanTodo.Controllers
{
    public class IntroductionController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            if (!HttpContext.Request.Cookies.ContainsKey("userinfo"))
            {
                HttpContext.Response.Cookies.Append("userinfo", DateTime.Now.ToString());
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
        }
    }
}
