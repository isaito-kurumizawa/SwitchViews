using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwitchViews.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id = "")
        {
            if (id.Equals("foo"))
            {
                return View(string.Format("~/Views/Home/{0}.cshtml", id), new Models.FooViewModel());
            }
            else if (id.Equals("bar"))
            {
                return View(string.Format("~/Views/Home/{0}.cshtml", id), new Models.BarViewModel());
            }
            return View(new Models.IndexViewModel());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}