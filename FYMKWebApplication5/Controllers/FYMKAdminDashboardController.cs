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
        List<MentorBioId> mentorBioIds = new List<MentorBioId>();
        List<MenteeCV> menteeCVs = new List<MenteeCV>();
        List<MatchingCheckbox> matchingCheckboxes = new List<MatchingCheckbox>();

        List<MenteeCount> menteeCounts = new List<MenteeCount>();
        List<MentorCount> mentorCounts = new List<MentorCount>();
        List<AdminMenteeMatching> adminMenteeMatchings = new List<AdminMenteeMatching>();
        List<CVMatching> cVMatchings = new List<CVMatching>();
        List<AdminCVMatching> adminCVMatchings = new List<AdminCVMatching>();
        List<AdminCareerMatching> adminCareerMatchings = new List<AdminCareerMatching>();
        List<CareerMatching> careerMatchings = new List<CareerMatching>();
        List<MatchRatio> MatchRatios = new List<MatchRatio>();
        List<MenteeFeedBack> MenteeFeedBacks = new List<MenteeFeedBack>();
        List<MatchingRatio> matchingRatios = new List<MatchingRatio>();






        //private readonly ILogger<FYMKAdminDashboardController> _logger;


        public FYMKAdminDashboardController()
        {
            //ILogger<FYMKAdminDashboardController> logger
            // _logger = logger;
            con.ConnectionString = FYMKWebApplication4.Properties.Resources.ConnectionString2;
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
            Session["MatchingRatio"] = matchingRatios;
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
                com.CommandText = "select Count (MenteeId) as IdCount From Mentees ";
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
                com.CommandText = "select Count (MentorId) as IdCount From Mentors";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    mentorCounts.Add(new MentorCount()
                    {
                        MentorId = dr["IdCount"].ToString()
                    });
                }
                con.Close();

            }
            catch (Exception)
            {

                throw;
            }


            if (matchingRatios.Count > 0)

            {
                matchingRatios.Clear();

            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT (select count(MenteeId)  from Mentees) / (select count(MentorId) from Mentors) as Total_Matched";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    matchingRatios.Add(new MatchingRatio()
                    {
                        MenteeId = dr["Total_Matched"].ToString()
                    ,
                        MentorId = dr["Total_Matched"].ToString()
                    ,
                        Total_Matched = dr["Total_Matched"].ToString()

                    });
                }
                con.Close();

            }
            catch (Exception)
            {

                throw;
            }


            if (menteeTables.Count > 0)
            {
                menteeTables.Clear();
            }

            try
            {

                con.Open();
                com.Connection = con;
                com.CommandText = "select Top (1000) [MenteeId],[FirstName],[LastName],[Email],[MyProper] From Mentees";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    menteeTables.Add(new MenteeTable() 
                    {
                        MenteeId = dr["MenteeId"].ToString()
                    ,
                        FirstName = dr["FirstName"].ToString() 
                    ,LastName = dr["LastName"].ToString()
                    ,Email = dr["Email"].ToString()
                    ,
                        MyProper = dr["MyProper"].ToString()
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
                com.CommandText = "select Top (1000) [FirstName],[LastName],[Email],[Date] From Mentors";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    mentorTables.Add(new MentorTable() { 
                     FirstName = dr["FirstName"].ToString()
                    ,
                        LastName = dr["LastName"].ToString()
                    ,
                        Email = dr["Email"].ToString()
                    ,
                        Date = dr["Date"].ToString()
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
            Session["CVMatching"] = cVMatchings;
            Session["MatchingCheckbox"] = matchingCheckboxes;
            Session["MenteeCV"] = menteeCVs;
            Session["AdminCVMatching"] = adminCVMatchings;
            Session["AdminCareerMatching"] = adminCareerMatchings;
            Session["CareerMatching"] = careerMatchings;

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
                com.CommandText = "Select Mentors.FirstName, Mentors.LastName, Mentors.Email, Mentors.Country, Case when Mentors.[Education] = 1 then 'Yes' Else 'No' End AS Education, Case when Mentors.Enterpreneurship = 1 then 'Yes' Else 'No' End AS Enterpreneurship, Case when Mentors.Employement = 1 then 'Yes' Else 'No' End AS Employement, Case when Mentors.Developing_Resilence = 1 then 'Yes' Else 'No' End AS Developing_Resilence, Case when Mentors.Volunteering = 1 then 'Yes' Else 'No' End AS Volunteering From Mentors";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    adminMatches.Add(new AdminMatch() 
                    {
                        FirstName = dr["FirstName"].ToString()

                    ,   LastName = dr["LastName"].ToString()

                    ,   Email = dr["Email"].ToString()
                    ,
                        Country = dr["Country"].ToString()
                    ,
                        Education = dr["Education"].ToString()
                    ,
                        Enterpreneurship = dr["Enterpreneurship"].ToString()
                    ,
                        Employement = dr["Employement"].ToString()
                    ,
                        Developing_Resilence = dr["Developing_Resilence"].ToString()
                    ,
                        Volunteering = dr["Volunteering"].ToString()

                    });
                }
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }


            if (adminCVMatchings.Count > 0)
            {
                adminCVMatchings.Clear();
            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "select Top (1000) [FirstName],[LastName],[Email],[Country],[Education],[Enterpreneurship],[Employement],[Developing_Resilence],[Volunteering] From Mentors where Mentors.Enterpreneurship = 1";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    adminCVMatchings.Add(new AdminCVMatching()
                    {
                        FirstName = dr["FirstName"].ToString()

                    ,
                        LastName = dr["LastName"].ToString()

                    ,
                        Email = dr["Email"].ToString()
                    ,
                        Country = dr["Country"].ToString()
                    ,
                        Education = dr["Education"].ToString()
                    ,
                        Enterpreneurship = dr["Enterpreneurship"].ToString()
                    ,
                        Employement = dr["Employement"].ToString()
                    ,
                        Developing_Resilence = dr["Developing_Resilence"].ToString()
                    ,
                        Volunteering = dr["Volunteering"].ToString()

                    });
                }
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }

            if (adminCareerMatchings.Count > 0)
            {
                adminCareerMatchings.Clear();
            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "select Top (1000) [FirstName],[LastName],[Email],[Country],[Education],[Enterpreneurship],[Employement],[Developing_Resilence],[Volunteering] From Mentors where Mentors.Volunteering= 1";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    adminCareerMatchings.Add(new AdminCareerMatching()
                    {
                        FirstName = dr["FirstName"].ToString()

                    ,
                        LastName = dr["LastName"].ToString()

                    ,
                        Email = dr["Email"].ToString()
                    ,
                        Country = dr["Country"].ToString()
                    ,
                        Education = dr["Education"].ToString()
                    ,
                        Enterpreneurship = dr["Enterpreneurship"].ToString()
                    ,
                        Employement = dr["Employement"].ToString()
                    ,
                        Developing_Resilence = dr["Developing_Resilence"].ToString()
                    ,
                        Volunteering = dr["Volunteering"].ToString()

                    });
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
                com.CommandText = "select Top (1000) [MenteeId],[FirstName],[Enterpreneurship],[Employment],[University],[Building],[Developing],[Resilence],[Volunteering],[College],[Career],[CareerOptions],[CV] from Mentees  where Mentees.Employment = 1";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    adminMenteeMatchings.Add(new AdminMenteeMatching() 
                    {
                        MenteeId = dr["MenteeId"].ToString()
                    ,
                        FirstName = dr["FirstName"].ToString()

                    ,   Enterpreneurship = dr["Enterpreneurship"].ToString()
                    ,
                        Employment = dr["Employment"].ToString()
                    ,
                        University = dr["University"].ToString()
                    ,
                        Building = dr["Building"].ToString()
                    ,
                        Developing = dr["Developing"].ToString()
                    ,
                        Resilence = dr["Resilence"].ToString()
                    ,
                        Volunteering = dr["Volunteering"].ToString()
                    ,
                        College = dr["College"].ToString()
                    ,
                        Career = dr["Career"].ToString()
                    ,
                        CareerOptions = dr["CareerOptions"].ToString()
                    ,
                        CV = dr["CV"].ToString()


                    });
                }
                con.Close();

            }
            catch (Exception)
            {

                throw;
            }



            if (cVMatchings.Count > 0)
            {
                cVMatchings.Clear();
            }

            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "select Top (1000) [MenteeId],[FirstName],[Enterpreneurship],[Employment],[University],[Building],[Developing],[Resilence],[Volunteering],[College],[Career],[CareerOptions],[CV] from Mentees  where Career = 1";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cVMatchings.Add(new CVMatching()
                    {
                        MenteeId = dr["MenteeId"].ToString()
                    ,
                        FirstName = dr["FirstName"].ToString()

                    ,
                        Enterpreneurship = dr["Enterpreneurship"].ToString()
                    ,
                        Employment = dr["Employment"].ToString()
                    ,
                        University = dr["University"].ToString()
                    ,
                        Building = dr["Building"].ToString()
                    ,
                        Developing = dr["Developing"].ToString()
                    ,
                        Resilence = dr["Resilence"].ToString()
                    ,
                        Volunteering = dr["Volunteering"].ToString()
                    ,
                        College = dr["College"].ToString()
                    ,
                        Career = dr["Career"].ToString()
                    ,
                        CareerOptions = dr["CareerOptions"].ToString()
                    ,
                        CV = dr["CV"].ToString()


                    });
                }
                con.Close();

            }
            catch (Exception)
            {

                throw;
            }

            if (careerMatchings.Count > 0)
            {
                careerMatchings.Clear();
            }

            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "Select Mentees.MenteeId, Mentees.FirstName,Case when Mentees.Enterpreneurship = 1 then 'Yes' Else 'No' End AS Enterpreneurship, Case when Mentees.Employment = 1 then 'Yes' Else 'No' End AS Employment, Case when Mentees.University = 1 then 'Yes' Else 'No' End AS University, Case when Mentees.Building = 1 then 'Yes' Else 'No' End AS Building, Case when Mentees.Developing = 1 then 'Yes' Else 'No' End AS Developing, Case when Mentees.Resilence = 1 then 'Yes' Else 'No' End AS Resilence, Case when Mentees.Volunteering = 1 then 'Yes' Else 'No' End AS Volunteering, Case when Mentees.College = 1 then 'Yes' Else 'No' End AS College, Case when Mentees.Career = 1 then 'Yes' Else 'No' End AS Career, Case when Mentees.CareerOptions = 1 then 'Yes' Else 'No' End AS CareerOptions, Case when Mentees.CV = 1 then 'Yes' Else 'No' End AS CV, Case when Mentees.Education = 1 then 'Yes' Else 'No' End AS Education From Mentees";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    careerMatchings.Add(new CareerMatching()
                    {
                        MenteeId = dr["MenteeId"].ToString()
                    ,
                        FirstName = dr["FirstName"].ToString()

                    ,
                        Enterpreneurship = dr["Enterpreneurship"].ToString()
                    ,
                        Employment = dr["Employment"].ToString()
                    ,
                        University = dr["University"].ToString()
                    ,
                        Building = dr["Building"].ToString()
                    ,
                        Developing = dr["Developing"].ToString()
                    ,
                        Resilence = dr["Resilence"].ToString()
                    ,
                        Volunteering = dr["Volunteering"].ToString()
                    ,
                        College = dr["College"].ToString()
                    ,
                        Career = dr["Career"].ToString()
                    ,
                        CareerOptions = dr["CareerOptions"].ToString()
                    ,
                        CV = dr["CV"].ToString()
                    ,
                        Education = dr["Education"].ToString()

                    });
                }
                con.Close();

            }
            catch (Exception)
            {

                throw;
            }


            if (matchingCheckboxes.Count > 0)
            {
                matchingCheckboxes.Clear();
            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "select CheckBox, Id from CheckB";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    matchingCheckboxes.Add(new MatchingCheckbox()
                    {
                        Checkbox = dr["Checkbox"].ToString(),
                        Id = dr["Id"].ToString()


                    });
                }
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }


            if (menteeCVs.Count > 0)
            {
                menteeCVs.Clear();
            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "select Top (1000) [MenteeId],[FirstName],[Enterpreneurship],[Employment],[University],[Building],[Developing],[Resilence],[Volunteering],[College],[Career],[CareerOptions],[CV] from Mentees where Mentees.CV = 1";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    menteeCVs.Add(new MenteeCV()
                    {
                       


                    });
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
                com.CommandText = "select Top (1000) [FirstName],[LastName],[Email],[Country],[Education],[Enterpreneurship],[Employement],[Developing_Resilence],[Volunteering] From Mentors";
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
                    ,
                        Education = dr["Education"].ToString()
                    ,
                        Enterpreneurship = dr["Enterpreneurship"].ToString()
                    ,
                        Employement = dr["Employement"].ToString()
                    ,
                        Developing_Resilence = dr["Developing_Resilence"].ToString()
                    ,
                        Volunteering = dr["Volunteering"].ToString()
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

        public ActionResult adminprogram2()
        {
            return View();
        }

        public ActionResult MatchRatio()
        {
            DullData();
            Session["MatchRatio"] = MatchRatios;
            return View();
        }

        private void DullData()
        {



            if (MatchRatios.Count > 0)
            {
                MatchRatios.Clear();
            }

            try
            {

                con.Open();
                com.Connection = con;
                com.CommandText = "Select Mentees.FirstName, Mentors.LastName from Mentors join Mentees ON Mentors.MentorId = Mentees.MentorId where (Mentors.MentorId = 1 OR Mentors.MentorId = 2 OR Mentors.MentorId = 3 OR Mentors.MentorId = 4 OR Mentors.MentorId = 5 OR Mentors.MentorId = 6 OR Mentors.MentorId = 7 OR Mentors.MentorId = 8 OR Mentors.MentorId = 9)";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    MatchRatios.Add(new MatchRatio()
                    {
                        FirstName = dr["FirstName"].ToString()
                    ,
                        LastName = dr["LastName"].ToString()
                    });

                }
                con.Close();

            }
            catch (Exception)
            {

                throw;
            }

        }


        public ActionResult MenteeFeedBack()
        {
            MenteeeData();
            Session["MenteeFeedBack"] = MenteeFeedBacks;
            return View(MenteeFeedBacks);
        }

        private void MenteeeData()
        {
            if (MenteeFeedBacks.Count > 0)
            {
                MenteeFeedBacks.Clear();
            }

            try
            {

                con.Open();
                com.Connection = con;
                com.CommandText = "select Top (1000) [Id],[Mentee_FirstName],[Mentee_LastName],[MentorName],[Comment]From Responses";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    MenteeFeedBacks.Add(new MenteeFeedBack()
                    {
                        Id = dr["Id"].ToString()
                    ,
                        Mentee_FirstName = dr["Mentee_FirstName"].ToString()
                    ,
                        Mentee_LastName = dr["Mentee_LastName"].ToString()
                    ,
                        MentorName = dr["MentorName"].ToString()  
                    ,   
                        Comment = dr["Comment"].ToString()


                    });

                }
                con.Close();

            }
            catch (Exception)
            {

                throw;
            }
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

        public ActionResult Email()
        {
            return View();
        }



    }

    public interface ILogger<T>
    {
    }
}