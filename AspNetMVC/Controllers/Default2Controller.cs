using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNetMVC.Controllers
{
    public class Default2Controller : ApiController
    {
        // GET: api/Default2
        int a = 1;
        public IEnumerable<string> Get()
        {
            //TempData["sa"] = "sat";
            a = 2;
            return new string[] { "value1", "value2" };
        }

        // GET: api/Default2/5
        public string Get(int id)
        {

            return a.ToString();
        }

        // POST: api/Default2
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default2/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default2/5
        public void Delete(int id)
        {
        }
    }
}
