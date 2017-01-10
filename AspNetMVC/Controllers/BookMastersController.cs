using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using AspNetMVC;

namespace AspNetMVC.Controllers
{
    /*
    在为此控制器添加路由之前，WebApiConfig 类可能要求你做出其他更改。请适当地将这些语句合并到 WebApiConfig 类的 Register 方法中。请注意 OData URL 区分大小写。

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using AspNetMVC;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<BookMaster>("BookMasters");
    builder.EntitySet<Publisher>("Publishers"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class BookMastersController : ODataController
    {
        private CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();

        // GET: odata/BookMasters
        [EnableQuery]
        public IQueryable<BookMaster> GetBookMasters()
        {
            return db.BookMasters;
        }

        // GET: odata/BookMasters(5)
        [EnableQuery]
        public SingleResult<BookMaster> GetBookMaster([FromODataUri] int key)
        {
            return SingleResult.Create(db.BookMasters.Where(bookMaster => bookMaster.Id == key));
        }

        // PUT: odata/BookMasters(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<BookMaster> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            BookMaster bookMaster = db.BookMasters.Find(key);
            if (bookMaster == null)
            {
                return NotFound();
            }

            patch.Put(bookMaster);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookMasterExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(bookMaster);
        }

        // POST: odata/BookMasters
        public IHttpActionResult Post(BookMaster bookMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BookMasters.Add(bookMaster);
            db.SaveChanges();

            return Created(bookMaster);
        }

        // PATCH: odata/BookMasters(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<BookMaster> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            BookMaster bookMaster = db.BookMasters.Find(key);
            if (bookMaster == null)
            {
                return NotFound();
            }

            patch.Patch(bookMaster);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookMasterExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(bookMaster);
        }

        // DELETE: odata/BookMasters(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            BookMaster bookMaster = db.BookMasters.Find(key);
            if (bookMaster == null)
            {
                return NotFound();
            }

            db.BookMasters.Remove(bookMaster);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/BookMasters(5)/Publishers
        [EnableQuery]
        public IQueryable<Publisher> GetPublishers([FromODataUri] int key)
        {
            return db.BookMasters.Where(m => m.Id == key).SelectMany(m => m.Publishers);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BookMasterExists(int key)
        {
            return db.BookMasters.Count(e => e.Id == key) > 0;
        }
    }
}
