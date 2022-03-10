using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using FYMKWebApplication5.Data;
using FYMKWebApplication5.Models;

namespace FYMKWebApplication5.Controllers
{
    public class AdminDashboardsController : ApiController
    {
        private FYMKWebApplication5Context db = new FYMKWebApplication5Context();

        // GET: api/AdminDashboards
        public IQueryable<AdminDashboard> GetAdminDashboards()
        {
            return db.AdminDashboards;
        }

        // GET: api/AdminDashboards/5
        [ResponseType(typeof(AdminDashboard))]
        public async Task<IHttpActionResult> GetAdminDashboard(int id)
        {
            AdminDashboard adminDashboard = await db.AdminDashboards.FindAsync(id);
            if (adminDashboard == null)
            {
                return NotFound();
            }

            return Ok(adminDashboard);
        }

        // PUT: api/AdminDashboards/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAdminDashboard(int id, AdminDashboard adminDashboard)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != adminDashboard.Id)
            {
                return BadRequest();
            }

            db.Entry(adminDashboard).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminDashboardExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/AdminDashboards
        [ResponseType(typeof(AdminDashboard))]
        public async Task<IHttpActionResult> PostAdminDashboard(AdminDashboard adminDashboard)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AdminDashboards.Add(adminDashboard);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = adminDashboard.Id }, adminDashboard);
        }

        

        // DELETE: api/AdminDashboards/5
        [ResponseType(typeof(AdminDashboard))]
        public async Task<IHttpActionResult> DeleteAdminDashboard(int id)
        {
            AdminDashboard adminDashboard = await db.AdminDashboards.FindAsync(id);
            if (adminDashboard == null)
            {
                return NotFound();
            }

            db.AdminDashboards.Remove(adminDashboard);
            await db.SaveChangesAsync();

            return Ok(adminDashboard);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AdminDashboardExists(int id)
        {
            return db.AdminDashboards.Count(e => e.Id == id) > 0;
        }
    }
}