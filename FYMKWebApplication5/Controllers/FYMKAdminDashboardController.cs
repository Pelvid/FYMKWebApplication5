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
        List<MentorTable> mentorTables = new List<MentorTable>();
        List<MenteeTable> menteeTables = new List<MenteeTable>();

        List<MenteeCount> menteeCounts = new List<MenteeCount>();
        List<MentorCount> mentorCounts = new List<MentorCount>();
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