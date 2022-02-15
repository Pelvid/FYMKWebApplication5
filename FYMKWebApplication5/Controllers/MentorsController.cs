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
    public class MentorsController : ApiController
    {
        private FYMKWebApplication5Context db = new FYMKWebApplication5Context();

        // GET: api/Mentors
        public IQueryable<Mentor> GetMentors()
        {
            return db.Mentors;
        }

        // GET: api/Mentors/5
        [ResponseType(typeof(Mentor))]
        public async Task<IHttpActionResult> GetMentor(int id)
        {
            Mentor mentor = await db.Mentors.FindAsync(id);
            if (mentor == null)
            {
                return NotFound();
            }

            return Ok(mentor);
        }

        // PUT: api/Mentors/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMentor(int id, Mentor mentor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mentor.Id)
            {
                return BadRequest();
            }

            db.Entry(mentor).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MentorExists(id))
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

        // POST: api/Mentors
        [ResponseType(typeof(Mentor))]
        public async Task<IHttpActionResult> PostMentor(Mentor mentor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Mentors.Add(mentor);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = mentor.Id }, mentor);
        }

        // DELETE: api/Mentors/5
        [ResponseType(typeof(Mentor))]
        public async Task<IHttpActionResult> DeleteMentor(int id)
        {
            Mentor mentor = await db.Mentors.FindAsync(id);
            if (mentor == null)
            {
                return NotFound();
            }

            db.Mentors.Remove(mentor);
            await db.SaveChangesAsync();

            return Ok(mentor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MentorExists(int id)
        {
            return db.Mentors.Count(e => e.Id == id) > 0;
        }
    }
}