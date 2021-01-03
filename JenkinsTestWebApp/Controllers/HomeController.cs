using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JenkinsTestWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        /// <summary>
        /// This our test page
        /// </summary>
        /// <returns>First n whole numbers</returns>
        public ActionResult JenkinsTest(int WholeNum = 21 )
        {
            ViewData["InputWholeNum"] = WholeNum;
            ViewBag.Message = "Your Integration Test Page";
            if (WholeNum > 20)
            {
                return View();
            }
            else
            {
                throw (new Exception("Out of the range"));
            }
        }
    }
}