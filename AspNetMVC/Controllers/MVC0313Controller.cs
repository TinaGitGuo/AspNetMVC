using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0313Controller : Controller
    {
        CodeFirstDbDemoEntities DbContext = new CodeFirstDbDemoEntities();
        public class AggregateDto
        {
            public BookMaster Organisation { get; set; }
            public List<Publisher> Meters { get; set; }
            public List<C__MigrationHistory> Sites { get; set; }
            public List<BookMaster> Contracts { get; set; }
        }

        //var query = await(from organisation in DbContext.Organisations
        //                  where organisation.ID == request.Id
        //                  join site in DbContext.Sites on organisation.Orgid equals site.Orgid
        //                  into sites_joined
        //                  from site_joined in sites_joined.DefaultIfEmpty()
        //                  from meter in DbContext.Meters.Where(var_meter => site_joined == null ? false : var_meter.SiteLocationID == site_joined.SiteLocationID).DefaultIfEmpty()
        //                  join contract in DbContext.Contracts on organisation.Orgid equals contract.orgid
        //                  into contracts_joined
        //                  from contract_joined in contracts_joined.DefaultIfEmpty()
        //                  select new AggregateDto
        //                  {
        //                      Organisation = new OrganisationDto { ID = organisation.ID, OrganisationName = organisation.OrganisationName },
        //                      Sites = --what goes here ?? ,
        //                      Meters = --and here,
        //                      Contracts = --and here
        //                  }).FirstOrDefaultAsync();

        // GET: MVC0313
        public ActionResult Index()
        {
            var c = (from organisation in DbContext.BookMasters
                     where organisation.Id == 1
                     join site in DbContext.C__MigrationHistory on organisation.Id.ToString() equals site.ProductVersion
                     into abc select new { abc=abc }).AsEnumerable().ToList() ;
             //c.FirstOrDefault().abc.
            //select  new AggregateDto { Organisation= new BookMaster { strAccessionId=   } } ; 
               var query = (from organisation in DbContext.BookMasters
                              where organisation.Id == 1
                              join site in DbContext.C__MigrationHistory on organisation.Id.ToString() equals site.ProductVersion
                              into sites_joined
                              from site_joined in sites_joined.DefaultIfEmpty()

                              from meter in DbContext.Publishers.Where(var_meter => site_joined == null ? false : var_meter.BookMaster_Id.ToString() == site_joined.ProductVersion).DefaultIfEmpty()

                              //join contract in DbContext.BookMasters on organisation.Id equals contract.Id
                              //into contracts_joined
                              //from contract_joined in contracts_joined.DefaultIfEmpty()
                              select new AggregateDto
                              {
                                  Organisation = new BookMaster
                                  {
                                      Id = organisation.Id,
                                      strAccessionId = organisation.strAccessionId
                                  },
                                  //Sites =  new List<C__MigrationHistory>() { new C__MigrationHistory() {  ProductVersion= .strAccessionId } },
                                  Meters = new List<Publisher>() { new Publisher() {  PublisherId    = meter.PublisherId } }
                                   
                              }).ToList();
            return View();
        }
        //public Action Index2() {
        //    return
        //        Json(
        //            new { ok = false, msg = main.DeleteFailure, mtype = GetMessageTypeText(Constants.MessageType.error) },
        //            JsonRequestBehavior.AllowGet);
        //    return Json(new { state = true, msg = "加载成功", data = result }, JsonRequestBehavior.AllowGet);
        //}
    //}
    }
}