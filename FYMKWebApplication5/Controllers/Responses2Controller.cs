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

namespace FYMKWebApplication5.Controllers
{
    public class Responses2Controller : Controller
    {
        private FYMKWebApplication5Context db = new FYMKWebApplication5Context();

        // GET: Responses2
        public async Task<ActionResult> Index()
        {
            return View(await db.Responses.ToListAsync());
        }

        // GET: Responses2/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Response response = await db.Responses.FindAsync(id);
            if (response == null)
            {
                return HttpNotFound();
            }
            return View(response);
        }

        // GET: Responses2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Responses2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Mentee_FirstName,Mentee_LastName,MentorName,Comment")] Response response)
        {
            if (ModelState.IsValid)
            {
                db.Responses.Add(response);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(response);
        }

        // GET: Responses2/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Response response = await db.Responses.FindAsync(id);
            if (response == null)
            {
                return HttpNotFound();
            }
            return View(response);
        }

        // POST: Responses2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Mentee_FirstName,Mentee_LastName,MentorName,Comment")] Response response)
        {
            if (ModelState.IsValid)
            {
                db.Entry(response).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(response);
        }

        // GET: Responses2/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Response response = await db.Responses.FindAsync(id);
            if (response == null)
            {
                return HttpNotFound();
            }
            return View(response);
        }

        // POST: Responses2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Response response = await db.Responses.FindAsync(id);
            db.Responses.Remove(response);
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
