using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0310Controller : Controller
    {
        CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();
        // GET: MVC0310
        public class TestDbSet<T> : DbSet<T>, IQueryable, IEnumerable<T>
    where T : class
        {
            ObservableCollection<T> _data;
            IQueryable _query;

            public TestDbSet()
            {
                _data = new ObservableCollection<T>();
                _query = _data.AsQueryable();
            }

            //public override T Add(T item)
            //{
            //    _data.Add(item);
            //    return item;
            //}
            
        }
        class TestProductDbSet : TestDbSet<BookMaster>
        {
            //public   BookMaster NoFind(params object[] keyValues)
            //{
            //    return this.SingleOrDefault(product => product.Id == (int)keyValues.Single());
            //}
            public override BookMaster  Find(params object[] keyValues)
            {
                return this.SingleOrDefault(product => product.Id != (int)keyValues.Single());
            }
        }

       
       
        public ActionResult Index()
        {
            DbSet<BookMaster> u = db.BookMasters;

            var o = db.BookMasters.ToList();
            //db.BookMasters
            //new object[] = new int[] { 1, 2, 3 };
            //IEnumerable<TestProductDbSet>[] g = o;
             //var y=o as IEnumerable<TestProductDbSet>[] g;
             //var y1=  y.NoFind(1, 2, 3);
            //var y2 = y.Find(2);
            //var d= db.BookMasters.NoFind(1, 2, 3);
            var t = db.BookMasters.SingleOrDefault(product => product.Id == (new int[]{ 1, 2, 3}).Single());
            //var b = (from i in db.BookMasters where i.Id != (new int[] { 1, 2 }).Single() select i).ToList();
            var c = db.BookMasters.SingleOrDefault(m => m.Id != (new int[] { 1, 2 }).Single());
            //this.SingleOrDefault(product => product.Id == (int)keyValues.Single());
            //var a =( from i in db.BookMasters where i.Id != (new int[] { 1, 2 }).Single() select i).ToList();
            return View();
        }
    }
}