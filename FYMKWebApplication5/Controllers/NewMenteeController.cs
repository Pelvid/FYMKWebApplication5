using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FYMKWebApplication5.Controllers
{
    public class NewMenteeController : Controller
    {
        // GET: NewMentee
        //[HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Mentee()
        {
            return View();
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult SendEmail()
        {
            return View();
        }


    }
}