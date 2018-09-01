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
using Contoso.Models;

namespace Contoso.Controllers
{
    public class DimCustomersController : ApiController
    {
        private ContosoRetailDWEntities db = new ContosoRetailDWEntities();

        // GET: api/DimCustomers
        [Authorize]
        public IQueryable<DimCustomer> GetDimCustomers()
        {
            return db.DimCustomers.OrderBy(f => f.FirstName).Skip(150).Take(50);
        }
        public IQueryable<DimCustomer> GetDimCustomersPaged(int NoPagina, int dimensionPagineo)
        {
            var registrosOmitir = NoPagina * dimensionPagineo;
            return db.DimCustomers.OrderBy(f => f.FirstName).Skip(registrosOmitir).Take(dimensionPagineo);
        }

        // GET: api/DimCustomers/5
        [ResponseType(typeof(DimCustomer))]
        public IHttpActionResult GetDimCustomer(int id)
        {
            DimCustomer dimCustomer = db.DimCustomers.Find(id);
            if (dimCustomer == null)
            {
                return NotFound();
            }

            return Ok(dimCustomer);
        }

        // PUT: api/DimCustomers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDimCustomer(int id, DimCustomer dimCustomer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dimCustomer.CustomerKey)
            {
                return BadRequest();
            }

            db.Entry(dimCustomer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DimCustomerExists(id))
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

        // POST: api/DimCustomers
        [ResponseType(typeof(DimCustomer))]
        public IHttpActionResult PostDimCustomer(DimCustomer dimCustomer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DimCustomers.Add(dimCustomer);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dimCustomer.CustomerKey }, dimCustomer);
        }

        // DELETE: api/DimCustomers/5
        [ResponseType(typeof(DimCustomer))]
        public IHttpActionResult DeleteDimCustomer(int id)
        {
            DimCustomer dimCustomer = db.DimCustomers.Find(id);
            if (dimCustomer == null)
            {
                return NotFound();
            }

            db.DimCustomers.Remove(dimCustomer);
            db.SaveChanges();

            return Ok(dimCustomer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DimCustomerExists(int id)
        {
            return db.DimCustomers.Count(e => e.CustomerKey == id) > 0;
        }
    }
}