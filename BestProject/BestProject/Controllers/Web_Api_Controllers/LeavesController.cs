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
using BestProject.Models;

namespace BestProject.Controllers.Web_Api_Controllers
{
    public class LeavesController : ApiController
    {
        private ProjectModelsContext db = new ProjectModelsContext();

        // GET: api/Leaves
        public IQueryable<Leaf> GetLeafs()
        {
            return db.Leafs;
        }

        // GET: api/Leaves/5
        [ResponseType(typeof(Leaf))]
        public async Task<IHttpActionResult> GetLeaf(int id)
        {
            Leaf leaf = await db.Leafs.FindAsync(id);
            if (leaf == null)
            {
                return NotFound();
            }

            return Ok(leaf);
        }

        // PUT: api/Leaves/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLeaf(int id, Leaf leaf)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != leaf.Id)
            {
                return BadRequest();
            }

            db.Entry(leaf).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LeafExists(id))
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

        // POST: api/Leaves
        [ResponseType(typeof(Leaf))]
        public async Task<IHttpActionResult> PostLeaf(Leaf leaf)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Leafs.Add(leaf);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = leaf.Id }, leaf);
        }

        // DELETE: api/Leaves/5
        [ResponseType(typeof(Leaf))]
        public async Task<IHttpActionResult> DeleteLeaf(int id)
        {
            Leaf leaf = await db.Leafs.FindAsync(id);
            if (leaf == null)
            {
                return NotFound();
            }

            db.Leafs.Remove(leaf);
            await db.SaveChangesAsync();

            return Ok(leaf);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LeafExists(int id)
        {
            return db.Leafs.Count(e => e.Id == id) > 0;
        }
    }
}