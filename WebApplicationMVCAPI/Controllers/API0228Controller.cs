using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace WebApplicationMVCAPI.Controllers
{
    public class API0228Controller : ApiController
    {
        // GET: api/API0228
        // GET: api/Default2
       public static int a = 1;
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


        // POST: api/API0228
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/API0228/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/API0228/5
        public void Delete(int id)
        {
        }
    }
}
