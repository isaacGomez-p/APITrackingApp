using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPI_DT_3k.Models;

namespace WebAPI_DT_3k.Controllers
{
    public class TmpDT_3k_EntregasController : ApiController
    {
        private Model_DT_3k db = new Model_DT_3k();

        // GET: api/TmpDT_3k_Entregas
        public IQueryable<TmpDT_3k_Entregas> GetTmpDT_3k_Entregas()
        {
            return db.TmpDT_3k_Entregas;
        }

        // GET: api/TmpDT_3k_Entregas/5
        [ResponseType(typeof(TmpDT_3k_Entregas))]
        public IHttpActionResult GetTmpDT_3k_Entregas(string id)
        {
            TmpDT_3k_Entregas tmpDT_3k_Entregas = db.TmpDT_3k_Entregas.Find(id);
            if (tmpDT_3k_Entregas == null)
            {
                return NotFound();
            }

            return Ok(tmpDT_3k_Entregas);
        }

        // PUT: api/TmpDT_3k_Entregas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTmpDT_3k_Entregas(string id, TmpDT_3k_Entregas tmpDT_3k_Entregas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tmpDT_3k_Entregas.Pedido)
            {
                return BadRequest();
            }

            db.Entry(tmpDT_3k_Entregas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TmpDT_3k_EntregasExists(id))
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

        // POST: api/TmpDT_3k_Entregas
        [ResponseType(typeof(TmpDT_3k_Entregas))]
        public IHttpActionResult PostTmpDT_3k_Entregas(TmpDT_3k_Entregas tmpDT_3k_Entregas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TmpDT_3k_Entregas.Add(tmpDT_3k_Entregas);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (TmpDT_3k_EntregasExists(tmpDT_3k_Entregas.Pedido))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tmpDT_3k_Entregas.Pedido }, tmpDT_3k_Entregas);
        }

        // DELETE: api/TmpDT_3k_Entregas/5
        [ResponseType(typeof(TmpDT_3k_Entregas))]
        public IHttpActionResult DeleteTmpDT_3k_Entregas(string id)
        {
            TmpDT_3k_Entregas tmpDT_3k_Entregas = db.TmpDT_3k_Entregas.Find(id);
            if (tmpDT_3k_Entregas == null)
            {
                return NotFound();
            }

            db.TmpDT_3k_Entregas.Remove(tmpDT_3k_Entregas);
            db.SaveChanges();

            return Ok(tmpDT_3k_Entregas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TmpDT_3k_EntregasExists(string id)
        {
            return db.TmpDT_3k_Entregas.Count(e => e.Pedido == id) > 0;
        }
    }
}