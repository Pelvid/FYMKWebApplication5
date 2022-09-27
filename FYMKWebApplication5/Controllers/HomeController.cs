using FYMKWebApplication5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FYMKWebApplication4.Models;
using System.Data.SqlClient;
using FYMKWebApplication5.Models;
using System.Net.Mail;
using System.Net;

namespace Login.Controllers
{
    public class HomeController : Controller
    {


        FYMKWebApplication5Context db = new FYMKWebApplication5Context();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con = new SqlConnection();

        List<GetMentorName> getMentorNames = new List<GetMentorName>();
        List<GetMenteeName> getmenteename = new List<GetMenteeName>();

        public HomeController()
        {
            //ILogger<FYMKAdminDashboardController> logger
            // _logger = logger;
            con.ConnectionString = FYMKWebApplication4.Properties.Resources.ConnectionString2;
        }

        public IEnumerable<object> Mentees1 { get; private set; }

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
        public ActionResult Loginclick(Mentee mentee)
        {

            var Mobj = db.Mentees.Where(x => x.Email.Equals(mentee.Email) && x.LastName.Equals(mentee.LastName)).FirstOrDefault();
            if (Mobj != null)
            {
                Session["MenteeName"] = Mobj.FirstName;
                Session["Mentee"] = Mobj.MenteeId;
                return RedirectToAction("FYMKMentee");
            }
            else if (Mobj == null)
            {
                //ViewBag.Error = "Incorrect";
                //return ViewBag();
                return RedirectToAction("Error");
            }
            else if (mentee.Email == "admin@gmail.com" && mentee.LastName == "admin")
            {
                return RedirectToAction("FYMKAdminDashboard");
            }

            return View();



            //var obj = db.Mentees.Where(x => x.Email.Equals(mentee.Email) && x.LastName.Equals(mentee.LastName)).FirstOrDefault();
            //if (obj != null)
            //{
            //    Session["Name"] = obj.FirstName;
            //    Session["UserId"] = obj.Id; 
            //    return RedirectToAction("FYMKMentee");
            //}
            //else if (mentee.Email == "admin@gmail.com" && mentee.LastName == "admin")
            //{
            //    return RedirectToAction("FYMKAdminDashboard");
            //}

            //return View();
        }

        public ActionResult FYMKMentee()
        {
            FetchData();
            string menteeName = Session["MenteeName"].ToString();
            Session["getmenteename"] = getmenteename;
            ViewBag.MenteeUsername = menteeName;
            return View(getmenteename);
            //return View();
        }

        public ActionResult FYMKAdminDashboard()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Front(Mentor mentor)
        {
            db.Mentors.Add(mentor);
            db.SaveChanges();
            return RedirectToAction("SignIn");
        }

        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(Mentor mentor)
        {
            var obj = db.Mentors.Where(x => x.Email.Equals(mentor.Email) && x.LastName.Equals(mentor.LastName)).FirstOrDefault();
            //if (obj != null)
            if (obj != null)
            {
                Session["Name"] = mentor.FirstName;
                return RedirectToAction("FYMKMentorDashboard");
            }
            else if (mentor.Email == "admin@gmail.com" && mentor.LastName == "admin")
            {
                return RedirectToAction("FYMKAdminDashboards");
            }

            return View("Tunji");
        }

        public ActionResult FYMKMentorDashboard()
        {

            FetchData();
            string myName = Session["Name"].ToString();
            Session["GetmentorName"] = getMentorNames;
            ViewBag.Username = myName;
            return View(getMentorNames);


            //FetchData();
            //string myName = Session["Name"].ToString();
            //Session["GetMentorName"] = getMentorNames;
            //ViewBag.Username = myName;
            //return View(getMentorNames);
        }

        public ActionResult FYMKAdminDashboards()
        {
            return View();
        }


        public ActionResult MentorSignIn()
        {

            return View();

        }


        public ActionResult MentorSignInClick(Mentor mentor)
        {

            var obj = db.Mentors.Where(x => x.Email.Equals(mentor.Email) && x.LastName.Equals(mentor.LastName)).FirstOrDefault();
            if (obj != null)
            {
                Session["Name"] = obj.FirstName;
                Session["UserId"] = obj.MentorId;
                Session["MenteeUserId"] = obj.MenteeId;
                return RedirectToAction("FYMKMentorDashboard");
            }
            else if (obj == null)
            {
                return RedirectToAction("Error");
            }
            else if (mentor.Email == "admin@gmail.com" && mentor.LastName == "admin")
            {
                return RedirectToAction("FYMKAdminDashboard");
            }

            return View();
            //   return View("vvv");
        }


        public ActionResult Error()
        {

            return View();

        }




        private void FetchData()
        {


            if (getMentorNames.Count > 0)

            {
                getMentorNames.Clear();

            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "Select  FirstName From Mentors ";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    getMentorNames.Add(new GetMentorName()
                    {
                        FirstName = dr["FirstName"].ToString()
                    });
                }
                con.Close();

            }
            catch (Exception)
            {

                throw;
            }

        }

    }

}