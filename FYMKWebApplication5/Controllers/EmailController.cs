using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;

namespace FYMKWebApplication5.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult SendEmail()
        {
            return View();
        }


        //this is a post request
        [HttpPost]
        public ActionResult SendEmail(string useremail)
        {
            string subject = "Welcome to FreshYouthMK Mentorship Program";
            string body = "Your Email is your UserName... And your LastName is the Password https://localhost:44386/Home/Login";

            WebMail.Send(useremail, subject, body, null, null, null, true, null, null, null, null, null,null);
            //WebMail.Send(useremail, subject, body, null, null, null, true, null, null, null, null, null, null);
            ViewBag.msg = "email sent succesfully....";
            return View();
        }
    }
}