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

namespace FYMKWebApplication5.Controllers
{
    public class Mentees1Controller : Controller
    {
        private FYMKWebApplication5Context db = new FYMKWebApplication5Context();

        // GET: Mentees1
        public async Task<ActionResult> Index()
        {
            var mentees = db.Mentees.Include(m => m.Mentor);

            return View(await mentees.ToListAsync());
        }



        // GET: Mentees1/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mentee mentee = await db.Mentees.FindAsync(id);
            if (mentee == null)
            {
                return HttpNotFound();
            }
            return View(mentee);
        }

        // GET: Mentees1/Create
        public ActionResult Create()
        {
            ViewBag.MentorId = new SelectList(db.Mentors, "Id", "FirstName");
            return View();
        }

        // POST: Mentees1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,FirstName,LastName,Address1,Address,City,State,PostalCode,Countries,Telephone,Email,Confirm,MyProperty,Gender,EthicGroup,Prefenrene,YourLanguage,Role,PartT_Time,Graduated,Training,Working,Working_Part_Time,Unemployed,GSCE,A_Levels,Higher,NameAddress,NameAddres,NameAdre,Citt,Province,PostalCod,SelectedCountryIso32,MyPropert,MyProper,Comment,PleaseTellUs,Weekly,Fortnight,Monthly,ONE_HOUR,ONE_FIVE,TWO_HOUR,Skills,If_Yes,Education,Enterpreneurship,Employment,University,Building,Developing,Resilence,Volunteering,College,Career,CareerOptions,CV,Getting,Finding,ChangingCareer,Interview,Visual_Arts,Watching_Films,Creating_Videos,Reading_Fiction,Litary_Works,Sport,Electronic_Video_Game,Music,Baking,Cooking,Volunteeringg,ProfessionalInterest,Science,Information,FInancial,Educations,Business,Legal,HealthCare,Engineering,Non_Profit,Politics,Marketting,ProfessionalInterestt,Outgoing,Funny,Lively,Businesss,Construtive,Emphathetic,Intuitive,Passionate,Reserved,Reflective,Vibrant,Others,Criminal,References,Refenrece,Addres,Addre,Sity,Region,Postal,SelectedCountryIso3,Emai,Reference,Refenrec,Adde,Addr,zity,Regio,PostalCo,SelectedCountryIso33,Emaill,Telephonee,Note,MentorId")] Mentee mentee)
        {
            if (ModelState.IsValid)
            {
                db.Mentees.Add(mentee);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");

            }

            ViewBag.MentorId = new SelectList(db.Mentors, "Id", "FirstName", mentee.MentorId);
            return View(mentee);
        }

        // GET: Mentees1/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mentee mentee = await db.Mentees.FindAsync(id);
            if (mentee == null)
            {
                return HttpNotFound();
            }
            ViewBag.MentorId = new SelectList(db.Mentors, "Id", "FirstName", mentee.MentorId);
            return View(mentee);
        }

        // POST: Mentees1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,FirstName,LastName,Address1,Address,City,State,PostalCode,Countries,Telephone,Email,Confirm,MyProperty,Gender,EthicGroup,Prefenrene,YourLanguage,Role,PartT_Time,Graduated,Training,Working,Working_Part_Time,Unemployed,GSCE,A_Levels,Higher,NameAddress,NameAddres,NameAdre,Citt,Province,PostalCod,SelectedCountryIso32,MyPropert,MyProper,Comment,PleaseTellUs,Weekly,Fortnight,Monthly,ONE_HOUR,ONE_FIVE,TWO_HOUR,Skills,If_Yes,Education,Enterpreneurship,Employment,University,Building,Developing,Resilence,Volunteering,College,Career,CareerOptions,CV,Getting,Finding,ChangingCareer,Interview,Visual_Arts,Watching_Films,Creating_Videos,Reading_Fiction,Litary_Works,Sport,Electronic_Video_Game,Music,Baking,Cooking,Volunteeringg,ProfessionalInterest,Science,Information,FInancial,Educations,Business,Legal,HealthCare,Engineering,Non_Profit,Politics,Marketting,ProfessionalInterestt,Outgoing,Funny,Lively,Businesss,Construtive,Emphathetic,Intuitive,Passionate,Reserved,Reflective,Vibrant,Others,Criminal,References,Refenrece,Addres,Addre,Sity,Region,Postal,SelectedCountryIso3,Emai,Reference,Refenrec,Adde,Addr,zity,Regio,PostalCo,SelectedCountryIso33,Emaill,Telephonee,Note,MentorId")] Mentee mentee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mentee).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.MentorId = new SelectList(db.Mentors, "Id", "FirstName", mentee.MentorId);
            return View(mentee);
        }

        // GET: Mentees1/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mentee mentee = await db.Mentees.FindAsync(id);
            if (mentee == null)
            {
                return HttpNotFound();
            }
            return View(mentee);
        }

        // POST: Mentees1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Mentee mentee = await db.Mentees.FindAsync(id);
            db.Mentees.Remove(mentee);
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