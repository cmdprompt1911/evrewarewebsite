using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace evrewarewebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Evreware, a market inteligence company.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Want more infomation?";

            return View();
        }
        public ActionResult test()
        {
            ViewBag.Message = "Your test page.";

            return View();
        }
    }
}
