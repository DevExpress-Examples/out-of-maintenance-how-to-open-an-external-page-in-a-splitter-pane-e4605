using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NavKB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NavBar() {
            return View("NavBar");
        }
        public ActionResult Menu() {
            return View("Menu");
        }
        public ActionResult TreeView() {
            return View("TreeView");
        }

        public ActionResult Content1() {
            return View("ContentPage1");
        }
        public ActionResult Content2() {
            return View("ContentPage2");
        }
    }
}