using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public   class MVC0307Controller : Controller
    {
        // GET: MVC0307
        public string codedump<t>()
        {
            string result = string.Empty;
            System.Reflection.PropertyInfo[] properties = typeof(t).GetProperties();
            foreach (System.Reflection.PropertyInfo item in properties)
            {
                result += string.Format("{0} = record.field<{1}>(\"{0}\"),", item.Name, item.PropertyType.FullName);
            }
            return result;
        }
        public ActionResult Index()
        {
            //using (IDataReader dr = _db.executereader(command))
            //{
            //    questionanswerlist = dr.getenumerator<BookMaster>(new BookMaster().createquestionanswerinfo).tolist();
            //}
         
            return View();
        }
      


}
}