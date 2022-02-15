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
using FYMKWebApplication4.Models;
using FYMKWebApplication5.Data;

namespace FYMKWebApplication5.Controllers
{
    public class MenteesController : ApiController
    {
        private FYMKWebApplication5Context db = new FYMKWebApplication5Context();

        // GET: api/Mentees
        public IQueryable<Mentee> GetMentees()
        {
            return db.Mentees;
        }

        // GET: api/Mentees/5
        [ResponseType(typeof(Mentee))]
        public async Task<IHttpActionResult> GetMentee(int id)
        {
            Mentee mentee = await db.Mentees.FindAsync(id);
            if (mentee == null)
            {
                return NotFound();
            }

            return Ok(mentee);
        }

        // PUT: api/Mentees/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMentee(int id, Mentee mentee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mentee.Id)
            {
                return BadRequest();
            }

            db.Entry(mentee).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenteeExists(id))
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

        // POST: api/Mentees
        [ResponseType(typeof(Mentee))]
        public async Task<IHttpActionResult> PostMentee(Mentee mentee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Mentees.Add(mentee);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = mentee.Id }, mentee);
        }

        // DELETE: api/Mentees/5
        [ResponseType(typeof(Mentee))]
        public async Task<IHttpActionResult> DeleteMentee(int id)
        {
            Mentee mentee = await db.Mentees.FindAsync(id);
            if (mentee == null)
            {
                return NotFound();
            }

            db.Mentees.Remove(mentee);
            await db.SaveChangesAsync();

            return Ok(mentee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MenteeExists(int id)
        {
            return db.Mentees.Count(e => e.Id == id) > 0;
        }
    }
}