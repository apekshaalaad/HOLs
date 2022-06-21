using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Mvc;
using Day3MVCAssign.Models;

namespace Day3MVCAssign.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["str1"] = "This is a string passed using ViewData";
            ViewData["num1"] = 100;

            ViewBag.str2 = "This is a string passed using ViewBag";
            ViewBag.num2 = 200;
            return View();

        }
        public ActionResult AddUser()
        {
            return View(); 
        }
        public ActionResult SaveUser(User u)
        {
            
            StreamWriter sw = new
                StreamWriter(Server.MapPath("~/App_Data/users.txt"), true);
            sw.WriteLine("User details added on: " +
                DateTime.Now.ToString());
            sw.WriteLine("Username: " + u.UserName);
            sw.WriteLine("Password: " + u.Password);
            sw.WriteLine();
            sw.Close();
            return Content("User details have been saved");
        }
        public ActionResult HtmlHelpers()
        {
            return View();
        }

    }
}