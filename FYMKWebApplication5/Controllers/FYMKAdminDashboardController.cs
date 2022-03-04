using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FYMKWebApplication5.Models;
using System.Data.SqlClient;






namespace FYMKWebApplication5.Controllers
{
   
    public class FYMKAdminDashboardController : Controller
    {

        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con = new SqlConnection();
        List<MenteeCount> menteeCounts = new List<MenteeCount>();
        List<MentorCount> mentorCounts = new List<MentorCount>();
        private readonly ILogger<FYMKAdminDashboardController> _logger;


        public FYMKAdminDashboardController()
        {
            //ILogger<FYMKAdminDashboardController> logger
            // _logger = logger;
            con.ConnectionString = FYMKWebApplication5.Properties.Resources.ConnectionString2;
        }

        public IEnumerable<object> Mentees1 { get; private set; }

        // GET: FYMKAdminDashboard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult adminalert()
        {
            return View();
        }
        public ActionResult admincalender()
        {
            return View();
        }
        public ActionResult admindashboard()
        {


            //int MentorCount = 6;
            //int Menteecount = 3;
            //int MatchRatio = 1;


            //Session["MentorCount"] = MentorCount;
         
            //Session["MatchRatio"] = MatchRatio;
            FetchData();
            Session["Menteecount"] = menteeCounts;
            Session["Mentorcount"] = mentorCounts;
            return View(mentorCounts);
            
        }


        private void FetchData()
        {
            if (mentorCounts.Count > 0)
                
            {
                mentorCounts.Clear();
                
            }

            if (menteeCounts.Count > 0)

            {
                menteeCounts.Clear();

            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "select (select Count (Id) From Mentees) as IdCount,(select Count (Id) From Mentors) as MeentorCnt";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    mentorCounts.Add(new MentorCount()
                    {
                        Id = dr["MeentorCnt"].ToString()
                    });
                }
                con.Close();

            }
            catch (Exception)
            {

                throw ;
            }

            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "select (select Count (Id) From Mentees) as IdCount,(select Count (Id) From Mentors) as MeentorCnt";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    menteeCounts.Add(new MenteeCount()
                    {
                        Id = dr["IdCount"].ToString()
                    });
                }
                con.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }


        public ActionResult adminmatch()
        {
        
            return View();
        }
        public ActionResult adminmentee()
        {
            return View();
        }
        public ActionResult adminmenteereview()
        {
            return View();
        }
        public ActionResult adminmentor()
        {
            return View();
        }
        public ActionResult adminmentorreview()
        {
            return View();
        }

        public ActionResult adminprofile()
        {
            return View();
        }
        public ActionResult adminprogram()
        {
            return View();
        }
        public ActionResult adminsettings()
        {
            return View();
        }
        public ActionResult chat()
        {
            return View();
        }
        public ActionResult helpcentre()
        {
            return View();
        }
        public ActionResult sidebar()
        {
            return View();
        }
    }

    public interface ILogger<T>
    {
    }
}