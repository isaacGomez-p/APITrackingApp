using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
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
        public IHttpActionResult PutTmpDT_3k_Entregas(string id, TmpDT_3k_EntregasDto tmpDT_3k_EntregasDto)
        {
            TmpDT_3k_Entregas datos = new TmpDT_3k_Entregas();
            string s = Convert.ToBase64String(Encoding.ASCII.GetBytes(tmpDT_3k_EntregasDto.Foto));
            datos.Foto = Convert.FromBase64String(s);
            datos.Asignado = tmpDT_3k_EntregasDto.Asignado;
            datos.Campania = tmpDT_3k_EntregasDto.Campania;
            datos.Causal_Id = tmpDT_3k_EntregasDto.Causal_Id;
            datos.Ciudad = tmpDT_3k_EntregasDto.Ciudad;
            datos.Conductor = tmpDT_3k_EntregasDto.Conductor;
            datos.Cond_Celular = tmpDT_3k_EntregasDto.Cond_Celular;
            datos.Depto = tmpDT_3k_EntregasDto.Depto;
            datos.Despacho = tmpDT_3k_EntregasDto.Despacho;
            datos.DestinoFinal = tmpDT_3k_EntregasDto.DestinoFinal;
            datos.Direccion = tmpDT_3k_EntregasDto.Direccion;
            datos.Entrega_Fec = tmpDT_3k_EntregasDto.Entrega_Fec;
            datos.Estado = tmpDT_3k_EntregasDto.Estado;
            datos.Id = tmpDT_3k_EntregasDto.Id;
            datos.Lat = tmpDT_3k_EntregasDto.Lat;
            datos.Lng = tmpDT_3k_EntregasDto.Lng;
            datos.Manifiesto = tmpDT_3k_EntregasDto.Manifiesto;
            datos.Pedido = tmpDT_3k_EntregasDto.Pedido;
            datos.Prec = tmpDT_3k_EntregasDto.Prec;
            datos.PreRuta = tmpDT_3k_EntregasDto.PreRuta;
            datos.Relacion_Fec = tmpDT_3k_EntregasDto.Relacion_Fec;
            datos.Relacion_Id = tmpDT_3k_EntregasDto.Relacion_Id;
            datos.Tel = tmpDT_3k_EntregasDto.Tel;
            datos.Vehi_Color = tmpDT_3k_EntregasDto.Vehi_Color;
            datos.Vehi_Placa = tmpDT_3k_EntregasDto.Vehi_Placa;
            datos.Vehi_Tipo = tmpDT_3k_EntregasDto.Vehi_Tipo;
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != datos.Pedido)
            {
                return BadRequest();
            }

            db.Entry(datos).State = EntityState.Modified;

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
            string s = Convert.ToBase64String(tmpDT_3k_Entregas.Foto);
            tmpDT_3k_Entregas.Foto = Convert.FromBase64String(s);
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