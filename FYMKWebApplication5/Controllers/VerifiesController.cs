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
    public class VerifiesController : ApiController
    {
        private FYMKWebApplication5Context db = new FYMKWebApplication5Context();

        // GET: api/Verifies
        public IQueryable<Verify> GetVerifies()
        {
            return db.Verifies;
        }

        // GET: api/Verifies/5
        [ResponseType(typeof(Verify))]
        public async Task<IHttpActionResult> GetVerify(int id)
        {
            Verify verify = await db.Verifies.FindAsync(id);
            if (verify == null)
            {
                return NotFound();
            }

            return Ok(verify);
        }

        // PUT: api/Verifies/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVerify(int id, Verify verify)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != verify.Id)
            {
                return BadRequest();
            }

            db.Entry(verify).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VerifyExists(id))
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

        // POST: api/Verifies
        [ResponseType(typeof(Verify))]
        public async Task<IHttpActionResult> PostVerify(Verify verify)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Verifies.Add(verify);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = verify.Id }, verify);
        }

        // DELETE: api/Verifies/5
        [ResponseType(typeof(Verify))]
        public async Task<IHttpActionResult> DeleteVerify(int id)
        {
            Verify verify = await db.Verifies.FindAsync(id);
            if (verify == null)
            {
                return NotFound();
            }

            db.Verifies.Remove(verify);
            await db.SaveChangesAsync();

            return Ok(verify);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VerifyExists(int id)
        {
            return db.Verifies.Count(e => e.Id == id) > 0;
        }
    }
}