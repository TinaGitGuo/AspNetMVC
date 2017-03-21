using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;

using System.Net.Http;
using System.Net;
using System.Web.Http;
//using System.Net;

namespace AspNetMVC.Controllers
{
    public class MVC0315Controller : Controller
    {
        CodeFirstDbDemoEntities _customerService = new CodeFirstDbDemoEntities();
        // GET: MVC0315
        public ActionResult Index()
        {
            //HttpRequestMessageExtensions.CreateResponse  
            //HttpContext.Request.CreateResponse("", "Customer not found");
            return View();
        }
        // CASE #1
        public BookMaster Get(string id)
        {
            var customer = new BookMaster();
            if (customer == null)
            {
                var notFoundResponse = new HttpResponseMessage(HttpStatusCode.NotFound);
                throw new HttpResponseException(notFoundResponse);
                HttpRequestMessage request = new HttpRequestMessage();
                var  response = request.CreateResponse(HttpStatusCode.OK, customer);
                response.Content.Headers.Expires = new DateTimeOffset(DateTime.Now.AddSeconds(300));
            }
           
            return customer;
        }

        //// CASE #2
        //public HttpResponseMessage Get(string id)
        //{
        //    var customer = _customerService.GetById(id);
        //    if (customer == null)
        //    {
        //        var notFoundResponse = new HttpResponseMessage(HttpStatusCode.NotFound);
        //        throw new HttpResponseException(notFoundResponse);
        //    }
        //    var response = Request.CreateResponse(HttpStatusCode.OK, customer);
        //    response.Content.Headers.Expires = new DateTimeOffset(DateTime.Now.AddSeconds(300));
        //    return response;
        //}

        // CASE #3
        //public HttpResponseMessage Get(string id)
        //{
        //    var customer = _customerService.GetById(id);
        //    if (customer == null)
        //    {
        //        var message = String.Format("customer with id: {0} was not found", id);
        //        var errorResponse = Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
        //        throw new HttpResponseException(errorResponse);
        //    }
        //    var response = Request.CreateResponse(HttpStatusCode.OK, customer);
        //    response.Content.Headers.Expires = new DateTimeOffset(DateTime.Now.AddSeconds(300));
        //    return response;
        //}

        // CASE #4
        //public HttpResponseMessage Get(string id)
        //{
        //    var customer = _customerService.GetById(id);
        //    if (customer == null)
        //    {
        //        var message = String.Format("customer with id: {0} was not found", id);
        //        var httpError = new HttpError(message);
        //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, httpError);
        //    }
        //    var response = Request.CreateResponse(HttpStatusCode.OK, customer);
        //    response.Content.Headers.Expires = new DateTimeOffset(DateTime.Now.AddSeconds(300));
        //    return response;
        //}
    }
}