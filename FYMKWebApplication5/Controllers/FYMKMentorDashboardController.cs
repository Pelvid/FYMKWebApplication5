using FYMKWebApplication5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FYMKWebApplication5.Models;
using FYMKWebApplication4.Models;


namespace FYMKWebApplication5.Controllers
{
    public class FYMKMentorDashboardController : Controller
    {
        FYMKWebApplication5Context db = new FYMKWebApplication5Context();
        // GET: FYMKMentor
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Mentee()
        {

            string userId = Session["UserId"].ToString();
            if(userId == null)
            {
                return RedirectToAction("MentorSignIn", "Home");
            }
            int id = Convert.ToInt32(userId);
            var obj = db.Mentees.Where(x => x.MentorId == id).ToList();
            return View(obj);
        }
        public ActionResult MentorAlert()
        {
            return View();
        }
        public ActionResult MentorCalender()
        {
            return View();
        }
        public ActionResult MentorDashboard()
        {
            
            return View();
        }
        public ActionResult MentorProfile()
        {
            return View();
        }
        public ActionResult MentoreProgram()
        {
            return View();
        }
        public ActionResult Chat()
        {
            return View();
        }
        public ActionResult Setting()
        {
            return View();
        }

        public ActionResult HelpCentre()
        {
            return View();
        }
    }
}