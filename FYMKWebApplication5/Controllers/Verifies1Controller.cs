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
    public class Verifies1Controller : Controller
    {
        private FYMKWebApplication5Context db = new FYMKWebApplication5Context();

        // GET: Verifies1
        public async Task<ActionResult> Index()
        {
            return View(await db.Verifies.ToListAsync());
        }

        // GET: Verifies1/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Verify verify = await db.Verifies.FindAsync(id);
            if (verify == null)
            {
                return HttpNotFound();
            }
            return View(verify);
        }

        // GET: Verifies1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Verifies1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Csharp,Python,CSS")] Verify verify)
        {
            if (ModelState.IsValid)
            {
                db.Verifies.Add(verify);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(verify);
        }

        // GET: Verifies1/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Verify verify = await db.Verifies.FindAsync(id);
            if (verify == null)
            {
                return HttpNotFound();
            }
            return View(verify);
        }

        // POST: Verifies1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Csharp,Python,CSS")] Verify verify)
        {
            if (ModelState.IsValid)
            {
                db.Entry(verify).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(verify);
        }

        // GET: Verifies1/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Verify verify = await db.Verifies.FindAsync(id);
            if (verify == null)
            {
                return HttpNotFound();
            }
            return View(verify);
        }

        // POST: Verifies1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Verify verify = await db.Verifies.FindAsync(id);
            db.Verifies.Remove(verify);
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
