using FYMKWebApplication5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FYMKWebApplication4.Models;

namespace Login.Controllers
{
    public class HomeController : Controller
    {
        FYMKWebApplication5Context db = new FYMKWebApplication5Context();
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Mentee mentee)
        {
            db.Mentees.Add(mentee);
            db.SaveChanges();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Mentee mentee)
        {
            var obj = db.Mentees.Where(x => x.Email.Equals(mentee.Email) && x.LastName.Equals(mentee.LastName)).FirstOrDefault();
            if (obj != null)
            {
                return RedirectToAction("FYMKMentorDashboard");
            }
            else if (mentee.Email == "admin@gmail.com" && mentee.LastName == "admin")
            {
                return RedirectToAction("FYMKAdminDashboard");
            }
            return View();
        }

        public ActionResult FYMKMentorDashboard()
        {
            return View();
        }

        public ActionResult FYMKAdminDashboard()
        {
            return View();
        }
    }

}