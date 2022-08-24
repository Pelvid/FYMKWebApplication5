using FYMKWebApplication5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FYMKWebApplication5.Controllers
{
    public class FYMKMenteeController : Controller
    {
        FYMKWebApplication5Context db = new FYMKWebApplication5Context();

        // GET: FYMKMentee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dashoard()
        {
            string MenteeName = Session["MenteeName"].ToString();
            if ( MenteeName == null)
            {
                return RedirectToAction("Dashoard", "FYMKMentee");

            }

            var obj = db.Mentees.Where(x => x.FirstName == MenteeName).ToList();

            return View(obj);
        }
        public ActionResult Program()
        {
            return View();

        }
        public ActionResult Chat()
        {
            return View();
        }
        public ActionResult MenteeCalender()
        {
            return View();
        }
        public ActionResult MenteeAlert()
        {
            return View();
        }
        public ActionResult HelpCentre()
        {
            return View();
        }
        public ActionResult MenteeProfile()
        {
            return View();
        }
        public ActionResult Settings()
        {
            return View();
        }
        public ActionResult Mentor()
        {
            string Mentee = Session["Mentee"].ToString();
            if (Mentee == null)
            {
                return RedirectToAction("Login", "Home");
            }
            int id = Convert.ToInt32(Mentee);
            var Mobj = db.Mentors.Where(x => x.MenteeId == id).ToList();
            return View(Mobj);

        }
        public ActionResult MenteeReg()
        {
            return View();
        }
    }
}