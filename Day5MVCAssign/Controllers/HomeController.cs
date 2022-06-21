using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day5MVCAssign.Controllers
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
        public ActionResult CreateAccount()
        {
            if (a.AccountNumber < 0)
            {
                ModelState.AddModelError("AccountNumber", "Account number cannot be negative");
            }
            if (string.IsNullOrEmpty(a.Name))
            {
                ModelState.AddModelError("Name", "Account holder's name is required");
            }
            if ((a.CurrentBalance >= 1 && a.CurrentBalance < 500) ||
                        a.CurrentBalance < 0)
            {
                ModelState.AddModelError("CurrentBalance", "Minimum  balance must be atleast 500");
            }

            if (ModelState.IsValid)
            {
                context.Accounts.Add(a);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create");

        }
    }
}