using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC2App.Models;

namespace MVC2App.Controllers
{
    [AiHandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";
            return View();
        }

        public ActionResult About()
        {
            var r = new Random();
            if (r.Next() % 2 == 0)
            {
                var c = new AboutModel();
                c.saySomething();
            }
            return View();
        }
    }
}
