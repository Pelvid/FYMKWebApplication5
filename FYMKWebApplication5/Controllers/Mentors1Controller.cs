using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FYMKWebApplication4.Models;
using FYMKWebApplication5.Data;
using System.Web.Helpers;

namespace FYMKWebApplication5.Controllers
{
    public class Mentors1Controller : Controller
    {
        private FYMKWebApplication5Context db = new FYMKWebApplication5Context();

        // GET: Mentors1
        public async Task<ActionResult> Index()
        {

            return View(await db.Mentors.ToListAsync());
            //return View(await db.Mentors.ToListAsync());
        }

        // GET: Mentors1/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mentor mentor = await db.Mentors.FindAsync(id);
            if (mentor == null)
            {
                return HttpNotFound();
            }
            return View(mentor);
        }

        // GET: Mentors1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mentors1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,FirstName,LastName,Address,Addresss,City,State,PostalCode,Country,Telephone,Email,ConrirmEmail,Date,Gender,PrefrenceOnGender,FirstLanguage,CriminalConvivtion,DBSCertificate,UpdatedDBS,GCSE,ALevel,Higher,StudyingOrWorking,InstituteOrUniversity,CourseStudying,StartDate,EndDate,Volunteer,WhyYouWantToMentor,YourExperience,WhenAreYouAvailable,SkillHobbies,SpecialNeed,Comment,Education,Enterpreneurship,Employement,Developing_Resilence,Volunteering,Changing_Career,Building_Confidence,Getting_Involved_In_Community_Work,Career_Without_University,Finding_Jobs_Locally,Developing_A_Professional_Network,CV_Writting,University_Applications,Interview_Skills,MyProperty,Visual_Arts,Watching_Films,Creating_Videos,Reading_Fiction,Litary_Works,Sport,Electronic_Video_Game,Music,Baking,Cooking,Volunteeringg,ProfessionalInterest,Science,Information,FInancial,Educations,Business,Legal,HealthCare,Engineering,Non_Profit,Politics,Marketting,Other,Outgoing,Funny,Lively,Businesss,Construtive,Emphathetic,Intuitive,Passionate,Reserved,Reflective,Vibrant,Others,Refenrence,Addressss,Address2,Cityy,Region,Code,Countryy,Telephonee,Refenrence2,Addresssss,AddressTwo,Cityyy,Regionn,Codee,Countryyy,Telephoneee,FinalNote,GDPR,MenteeId,Male,Female,MentorMale,MentorFemale,Username,Password,Re_TypePassword")] Mentor mentor)
        {
            if (ModelState.IsValid)
            {
                db.Mentors.Add(mentor);
                await db.SaveChangesAsync();
                string subject = "Welcome to FreshYouthMK Mentorship Program ";
                string body = "Your Email is your UserName... And your LastName is the Password https://instagram.com/ishepelvid?r=nametag";
                WebMail.Send(mentor.Email, subject, body, null, null, null, true, null, null, null, null, null, null);
                //WebMail.Send(useremail, subject, body, null, null, null, true, null, null, null, null, null, null);
                ViewBag.msg = "email sent succesfully....";
                return RedirectToAction("Index", "Mentors1");
                //return RedirectToAction("Index", "Mentors1");
            }

            return View(mentor);
        }


        public ActionResult sendMail(string email)
        {

            string subject = "Welcome to FreshYouthMK Mentorship Program ";
            string body = "Your Email is your UserName... And your LastName is the Password https://instagram.com/ishepelvid?r=nametag";
            WebMail.Send(email, subject, body, null, null, null, true, null, null, null, null, null, null);
            //WebMail.Send(useremail, subject, body, null, null, null, true, null, null, null, null, null, null);
            ViewBag.msg = "email sent succesfully....";
            return View();
        }

        // GET: Mentors1/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mentor mentor = await db.Mentors.FindAsync(id);
            if (mentor == null)
            {
                return HttpNotFound();
            }
            return View(mentor);
        }

        // POST: Mentors1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MentorId,FirstName,LastName,Address,Addresss,City,State,PostalCode,Country,Telephone,Email,ConrirmEmail,Date,Gender,PrefrenceOnGender,FirstLanguage,CriminalConvivtion,DBSCertificate,UpdatedDBS,GCSE,ALevel,Higher,StudyingOrWorking,InstituteOrUniversity,CourseStudying,StartDate,EndDate,Volunteer,WhyYouWantToMentor,YourExperience,WhenAreYouAvailable,SkillHobbies,SpecialNeed,Comment,Education,Enterpreneurship,Employement,Developing_Resilence,Volunteering,Changing_Career,Building_Confidence,Getting_Involved_In_Community_Work,Career_Without_University,Finding_Jobs_Locally,Developing_A_Professional_Network,CV_Writting,University_Applications,Interview_Skills,MyProperty,Visual_Arts,Watching_Films,Creating_Videos,Reading_Fiction,Litary_Works,Sport,Electronic_Video_Game,Music,Baking,Cooking,Volunteeringg,ProfessionalInterest,Science,Information,FInancial,Educations,Business,Legal,HealthCare,Engineering,Non_Profit,Politics,Marketting,Other,Outgoing,Funny,Lively,Businesss,Construtive,Emphathetic,Intuitive,Passionate,Reserved,Reflective,Vibrant,Others,Refenrence,Addressss,Address2,Cityy,Region,Code,Countryy,Telephonee,Refenrence2,Addresssss,AddressTwo,Cityyy,Regionn,Codee,Countryyy,Telephoneee,FinalNote,GDPR,MenteeId,Male,Female,MentorMale,MentorFemale,Username,Password,Re_TypePassword")] Mentor mentor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mentor).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(mentor);
        }

        // GET: Mentors1/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mentor mentor = await db.Mentors.FindAsync(id);
            if (mentor == null)
            {
                return HttpNotFound();
            }
            return View(mentor);
        }

        // POST: Mentors1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Mentor mentor = await db.Mentors.FindAsync(id);
            db.Mentors.Remove(mentor);
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
    }
}