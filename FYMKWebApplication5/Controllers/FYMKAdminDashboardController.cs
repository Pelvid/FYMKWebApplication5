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
        List<AdminMenteeReview> adminMenteeReviews = new List<AdminMenteeReview>();
        List<AdminMentorReview> adminMentorReviews = new List<AdminMentorReview>();
        List<AdminMatch> adminMatches = new List<AdminMatch>();
        List<MentorTable> mentorTables = new List<MentorTable>();
        List<MenteeTable> menteeTables = new List<MenteeTable>();

        List<MenteeCount> menteeCounts = new List<MenteeCount>();
        List<MentorCount> mentorCounts = new List<MentorCount>();
        List<AdminMenteeMatching> adminMenteeMatchings = new List<AdminMenteeMatching>();
        //private readonly ILogger<FYMKAdminDashboardController> _logger;


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
            Session["MenteeTable"] = menteeTables;
            Session["MentorTable"] = mentorTables;
            return View(mentorCounts);
            
        }


        private void FetchData()
        {
           

            if (menteeCounts.Count > 0)

            {
                menteeCounts.Clear();

            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "select Count (Id) as IdCount From Mentees ";
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


            if (mentorCounts.Count > 0)

            {
                mentorCounts.Clear();

            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "select Count (Id) as IdCount From Mentors";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    mentorCounts.Add(new MentorCount()
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


            if(menteeTables.Count > 0)
            {
                menteeTables.Clear();
            }

            try
            {

                con.Open();
                com.Connection = con;
                com.CommandText = "select Top (1000) [FirstName],[LastName],[Email] From Mentees";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    menteeTables.Add(new MenteeTable() { FirstName = dr["FirstName"].ToString() 
                    ,LastName = dr["LastName"].ToString()
                    ,Email = dr["Email"].ToString()
                    });
                }
                con.Close();

            }
            catch (Exception)
            {

                throw;
            }


            if(mentorTables.Count > 0)
            {
                mentorTables.Clear();
            }

            try
            {

                con.Open();
                com.Connection = con;
                com.CommandText = "select Top (1000) [FirstName],[LastName],[Email] From Mentors";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    mentorTables.Add(new MentorTable() { FirstName = dr["FirstName"].ToString()
                    ,LastName = dr["LastName"].ToString()
                    ,Email = dr["Email"].ToString()
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
            GetData();
            Session["AdminMatch"] = adminMatches;
            Session["AdminMenteeMatching"] = adminMenteeMatchings;
            return View(adminMatches);
        }

        private void GetData()
        {

            if(adminMatches.Count > 0)
            {
                adminMatches.Clear();
            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "select FirstName From Mentors where Id = 2";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    adminMatches.Add(new AdminMatch() {FirstName = dr["FirstName"].ToString() });
                }
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }

            if (adminMenteeMatchings.Count > 0)
            {
                adminMenteeMatchings.Clear();
            }

            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "select FirstName from Mentees";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    adminMenteeMatchings.Add(new AdminMenteeMatching() { FirstName = dr["FirstName"].ToString() });
                }
                con.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }


        public ActionResult adminmentee()
        {
            return View();
        }
        public ActionResult adminmenteereview()
        {
            RequestData();
            Session["AdminMenteeReview"] = adminMenteeReviews;
            return View(adminMenteeReviews);
        }

        private void RequestData()
        {

            if (adminMenteeReviews.Count > 0)
            {
                adminMenteeReviews.Clear();
            }

            try
            {

                con.Open();
                com.Connection = con;
                com.CommandText = "select Top (1000) [FirstName],[LastName],[Email],[Countries] From Mentees";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    adminMenteeReviews.Add(new AdminMenteeReview()
                    {
                        FirstName = dr["FirstName"].ToString()
                    ,
                        LastName = dr["LastName"].ToString()
                    ,
                        Email = dr["Email"].ToString()
                    ,
                        Countries = dr["Countries"].ToString()
                    });

                }
                con.Close();

            }
            catch (Exception)
            {

                throw;
            }

        }

        public ActionResult adminmentor()
        {
            return View();
        }
        public ActionResult adminmentorreview()
        {
            PullData();
            Session["AdminMentorReview"] = adminMentorReviews;
            return View(adminMentorReviews);
        }
         private void PullData()
        {



            if (adminMentorReviews.Count > 0)
            {
                adminMentorReviews.Clear();
            }

            try
            {

                con.Open();
                com.Connection = con;
                com.CommandText = "select Top (1000) [FirstName],[LastName],[Email],[Country] From Mentors";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    adminMentorReviews.Add(new AdminMentorReview()
                    {
                        FirstName = dr["FirstName"].ToString()
                    ,
                        LastName = dr["LastName"].ToString()
                    ,
                        Email = dr["Email"].ToString()
                    ,   Country = dr["Country"].ToString()
                    });

                }
                con.Close();

            }
            catch (Exception)
            {

                throw;
            }

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
        public ActionResult Successful_Created()
        {
            return View();
        }
    }

    public interface ILogger<T>
    {
    }
}