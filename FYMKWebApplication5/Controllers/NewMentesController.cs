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
    public class NewMentesController : ApiController
    {
        private FYMKWebApplication5Context db = new FYMKWebApplication5Context();

        // GET: api/NewMentes
        public IQueryable<NewMente> GetNewMentes()
        {
            return db.NewMentes;
        }

        // GET: api/NewMentes/5
        [ResponseType(typeof(NewMente))]
        public async Task<IHttpActionResult> GetNewMente(int id)
        {
            NewMente newMente = await db.NewMentes.FindAsync(id);
            if (newMente == null)
            {
                return NotFound();
            }

            return Ok(newMente);
        }

        // PUT: api/NewMentes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutNewMente(int id, NewMente newMente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != newMente.Id)
            {
                return BadRequest();
            }

            db.Entry(newMente).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewMenteExists(id))
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

        // POST: api/NewMentes
        [ResponseType(typeof(NewMente))]
        public async Task<IHttpActionResult> PostNewMente(NewMente newMente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.NewMentes.Add(newMente);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = newMente.Id }, newMente);
        }

        // DELETE: api/NewMentes/5
        [ResponseType(typeof(NewMente))]
        public async Task<IHttpActionResult> DeleteNewMente(int id)
        {
            NewMente newMente = await db.NewMentes.FindAsync(id);
            if (newMente == null)
            {
                return NotFound();
            }

            db.NewMentes.Remove(newMente);
            await db.SaveChangesAsync();

            return Ok(newMente);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NewMenteExists(int id)
        {
            return db.NewMentes.Count(e => e.Id == id) > 0;
        }



    }
}