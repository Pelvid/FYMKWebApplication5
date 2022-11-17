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
    public class C_MenteeController : ApiController
    {
        private FYMKWebApplication5Context db = new FYMKWebApplication5Context();

        // GET: api/C_Mentee
        public IQueryable<C_Mentee> GetC_Mentee()
        {
            return db.C_Mentee;
        }

        // GET: api/C_Mentee/5
        [ResponseType(typeof(C_Mentee))]
        public async Task<IHttpActionResult> GetC_Mentee(int id)
        {
            C_Mentee c_Mentee = await db.C_Mentee.FindAsync(id);
            if (c_Mentee == null)
            {
                return NotFound();
            }

            return Ok(c_Mentee);
        }

        // PUT: api/C_Mentee/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutC_Mentee(int id, C_Mentee c_Mentee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != c_Mentee.id)
            {
                return BadRequest();
            }

            db.Entry(c_Mentee).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!C_MenteeExists(id))
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

        // POST: api/C_Mentee
        [ResponseType(typeof(C_Mentee))]
        public async Task<IHttpActionResult> PostC_Mentee(C_Mentee c_Mentee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.C_Mentee.Add(c_Mentee);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = c_Mentee.id }, c_Mentee);
        }

        // DELETE: api/C_Mentee/5
        [ResponseType(typeof(C_Mentee))]
        public async Task<IHttpActionResult> DeleteC_Mentee(int id)
        {
            C_Mentee c_Mentee = await db.C_Mentee.FindAsync(id);
            if (c_Mentee == null)
            {
                return NotFound();
            }

            db.C_Mentee.Remove(c_Mentee);
            await db.SaveChangesAsync();

            return Ok(c_Mentee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool C_MenteeExists(int id)
        {
            return db.C_Mentee.Count(e => e.id == id) > 0;
        }
    }
}