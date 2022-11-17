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
    public class C_Mentee1Controller : Controller
    {
        private FYMKWebApplication5Context db = new FYMKWebApplication5Context();

        // GET: C_Mentee1
        public async Task<ActionResult> Index()
        {
            return View(await db.C_Mentee.ToListAsync());
        }

        // GET: C_Mentee1/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_Mentee c_Mentee = await db.C_Mentee.FindAsync(id);
            if (c_Mentee == null)
            {
                return HttpNotFound();
            }
            return View(c_Mentee);
        }

        // GET: C_Mentee1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: C_Mentee1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,FirstName,LastName,Address1,Address,City,State,PostalCode,Countries,Telephone,Email,Confirm,MyProperty,Gender,EthicGroup,Prefenrene,YourLanguage,Role,PartT_Time,Graduated,Training,Working,Working_Part_Time,Unemployed,GSCE,A_Levels,Higher,NameAddress,NameAddres,NameAdre,Citt,Province,PostalCod,SelectedCountryIso32,MyPropert,MyProper,Comment,PleaseTellUs,Weekly,Fortnight,Monthly,ONE_HOUR,ONE_FIVE,TWO_HOUR,Skills,If_Yes,Education,Enterpreneurship,Employment,University,Building,Developing,Resilence,Volunteering,College,Career,CareerOptions,CV,Getting,Finding,ChangingCareer,Interview,Visual_Arts,Watching_Films,Creating_Videos,Reading_Fiction,Litary_Works,Sport,Electronic_Video_Game,Music,Baking,Cooking,Volunteeringg,ProfessionalInterest,Science,Information,FInancial,Educations,Business,Legal,HealthCare,Engineering,Non_Profit,Politics,Marketting,ProfessionalInterestt,Outgoing,Funny,Lively,Businesss,Construtive,Emphathetic,Intuitive,Passionate,Reserved,Reflective,Vibrant,Others,Criminal,References,Refenrece,Addres,Addre,Sity,Region,Postal,SelectedCountryIso3,Emai,Reference,Refenrec,Adde,Addr,zity,Regio,PostalCo,SelectedCountryIso33,Emaill,Telephonee,Note")] C_Mentee c_Mentee)
        {
            if (ModelState.IsValid)
            {
                db.C_Mentee.Add(c_Mentee);
                await db.SaveChangesAsync();
                string subject = "Welcome to FreshYouthMK Mentorship Program ";
                string body = "Your Email is your UserName... And your LastName is the Password https://instagram.com/ishepelvid?r=nametag";
                WebMail.Send(c_Mentee.Email, subject, body, null, null, null, true, null, null, null, null, null, null);
                //WebMail.Send(useremail, subject, body, null, null, null, true, null, null, null, null, null, null);
                ViewBag.msg = "email sent succesfully....";
                return RedirectToAction("Index");
            }

            return View(c_Mentee);
        }

        // GET: C_Mentee1/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_Mentee c_Mentee = await db.C_Mentee.FindAsync(id);
            if (c_Mentee == null)
            {
                return HttpNotFound();
            }
            return View(c_Mentee);
        }

        // POST: C_Mentee1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,FirstName,LastName,Address1,Address,City,State,PostalCode,Countries,Telephone,Email,Confirm,MyProperty,Gender,EthicGroup,Prefenrene,YourLanguage,Role,PartT_Time,Graduated,Training,Working,Working_Part_Time,Unemployed,GSCE,A_Levels,Higher,NameAddress,NameAddres,NameAdre,Citt,Province,PostalCod,SelectedCountryIso32,MyPropert,MyProper,Comment,PleaseTellUs,Weekly,Fortnight,Monthly,ONE_HOUR,ONE_FIVE,TWO_HOUR,Skills,If_Yes,Education,Enterpreneurship,Employment,University,Building,Developing,Resilence,Volunteering,College,Career,CareerOptions,CV,Getting,Finding,ChangingCareer,Interview,Visual_Arts,Watching_Films,Creating_Videos,Reading_Fiction,Litary_Works,Sport,Electronic_Video_Game,Music,Baking,Cooking,Volunteeringg,ProfessionalInterest,Science,Information,FInancial,Educations,Business,Legal,HealthCare,Engineering,Non_Profit,Politics,Marketting,ProfessionalInterestt,Outgoing,Funny,Lively,Businesss,Construtive,Emphathetic,Intuitive,Passionate,Reserved,Reflective,Vibrant,Others,Criminal,References,Refenrece,Addres,Addre,Sity,Region,Postal,SelectedCountryIso3,Emai,Reference,Refenrec,Adde,Addr,zity,Regio,PostalCo,SelectedCountryIso33,Emaill,Telephonee,Note")] C_Mentee c_Mentee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c_Mentee).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(c_Mentee);
        }

        // GET: C_Mentee1/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_Mentee c_Mentee = await db.C_Mentee.FindAsync(id);
            if (c_Mentee == null)
            {
                return HttpNotFound();
            }
            return View(c_Mentee);
        }

        // POST: C_Mentee1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            C_Mentee c_Mentee = await db.C_Mentee.FindAsync(id);
            db.C_Mentee.Remove(c_Mentee);
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
