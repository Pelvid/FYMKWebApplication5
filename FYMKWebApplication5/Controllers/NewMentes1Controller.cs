using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FYMKWebApplication5.Data;
using FYMKWebApplication5.Models;
using System.Web.Helpers;

namespace FYMKWebApplication5.Controllers
{
    public class NewMentes1Controller : Controller
    {
        private FYMKWebApplication5Context db = new FYMKWebApplication5Context();

        // GET: NewMentes1
        public async Task<ActionResult> Index()
        {
            return View(await db.NewMentes.ToListAsync());
        }

        // GET: NewMentes1/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewMente newMente = await db.NewMentes.FindAsync(id);
            if (newMente == null)
            {
                return HttpNotFound();
            }
            return View(newMente);
        }

        // GET: NewMentes1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewMentes1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,firstName,lastName,address,address_line1,address_line2,city,stateProvinceRegion,postalCode,country,telephone,email,dateOfBirth,gender,ethnic_group,menteeGenderPreference,menteeGender_Preference,edHeader,GSCE,A_levels,HED_U,address_,address_lineOne,address_lineTwo,cityy,stateProvinceRegionn,postalCodee,countryy,skills_and_hobbies,visual_art,movies_cinema,creating_videos,reading,sports,video_games,music,banking,cooking,volunteering,science_technology,financial_services,Educa_tion,business_development,informatoin_technology,law_legal_litigation,medicine_healthcare,engineering,publishing,non_profit_charity_administration,politics,marketing_advertising,other_professional_interests_div,outgoing,funny,lively,business_oriented,constructive,empathetic,intuitive,passionate,reserved,reflective,vibrant,other_personal_description_div,current_challenges_div,expected_gain_div,volunteering_div,Weekly,Fortnightly,Monthly,One_hour,OneFive_hour,Two_hours,disability_option,special_need_brief,Educationn,Employment,Entrepreneurship,developing_resilience,college_options,career_without_niversity,building_confidence,volunteering_,interview_skills,getting_involved_in_community_work,career_options,changing_career,finding_Jobs_locally,CV_writing,university_applications,developing_a_professional_network")] NewMente newMente)
        {
            if (ModelState.IsValid)
            {
                db.NewMentes.Add(newMente);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(newMente);
        }

        // GET: NewMentes1/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewMente newMente = await db.NewMentes.FindAsync(id);
            if (newMente == null)
            {
                return HttpNotFound();
            }
            return View(newMente);
        }

        // POST: NewMentes1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,firstName,lastName,address,address_line1,address_line2,city,stateProvinceRegion,postalCode,country,telephone,email,dateOfBirth,gender,ethnic_group,menteeGenderPreference,menteeGender_Preference,edHeader,GSCE,A_levels,HED_U,address_,address_lineOne,address_lineTwo,cityy,stateProvinceRegionn,postalCodee,countryy,skills_and_hobbies,visual_art,movies_cinema,creating_videos,reading,sports,video_games,music,banking,cooking,volunteering,science_technology,financial_services,Educa_tion,business_development,informatoin_technology,law_legal_litigation,medicine_healthcare,engineering,publishing,non_profit_charity_administration,politics,marketing_advertising,other_professional_interests_div,outgoing,funny,lively,business_oriented,constructive,empathetic,intuitive,passionate,reserved,reflective,vibrant,other_personal_description_div,current_challenges_div,expected_gain_div,volunteering_div,Weekly,Fortnightly,Monthly,One_hour,OneFive_hour,Two_hours,disability_option,special_need_brief,Educationn,Employment,Entrepreneurship,developing_resilience,college_options,career_without_niversity,building_confidence,volunteering_,interview_skills,getting_involved_in_community_work,career_options,changing_career,finding_Jobs_locally,CV_writing,university_applications,developing_a_professional_network")] NewMente newMente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newMente).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(newMente);
        }

        // GET: NewMentes1/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewMente newMente = await db.NewMentes.FindAsync(id);
            if (newMente == null)
            {
                return HttpNotFound();
            }
            return View(newMente);
        }

        // POST: NewMentes1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            NewMente newMente = await db.NewMentes.FindAsync(id);
            db.NewMentes.Remove(newMente);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


        public ActionResult SendEmail()
        {
            return View();
        }


        //this is a post request
        [HttpPost]
        public ActionResult SendEmail(string useremail)
        {
            string subject = "Welcome to FreshYouthMK Mentorship Program ";
            string body = "Your Email is your UserName... And your LastName is the Password https://instagram.com/ishepelvid?r=nametag";
            WebMail.Send(useremail, subject, body, null, null, null, true, null, null, null, null, null, null);
            //WebMail.Send(useremail, subject, body, null, null, null, true, null, null, null, null, null, null);
            ViewBag.msg = "email sent succesfully....";
            return View();
        }
    }
}
