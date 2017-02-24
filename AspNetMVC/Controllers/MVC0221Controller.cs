using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0221Controller : Controller
    {
        CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();
        // GET: MVC0221
        public ActionResult Index()
        {
          var a=  new Guid();
            //var showbind = (from t1 in db.tbl_RegistrationPartners
            //                join t2 in db.aspnet_Memberships
            //                on t1.UserId equals t2.UserId
            //                join t3 in db.aspnet_UsersInRoles
            //                on t1.UserId equals t3.UserId
            //                where t1.ApplicationId == applicationid() && t2.IsApproved == true && t3.RoleId == new Guid("F03F89DB-6CBA-4B81-B75B-89BB08B0BD96") &&
            //                (t1.FirstName.Contains(txtSearch.Text.Trim()) ||
            //                 t1.LastName.Contains(txtSearch.Text.Trim()) ||
            //                 t1.CompanyName.Contains(txtSearch.Text.Trim()) ||
            //                 t1.ContactPhone.Contains(txtSearch.Text.Trim()) ||
            //                 t1.CellPhone.Contains(txtSearch.Text.Trim()) ||
            //                 t1.SkypeName.Contains(txtSearch.Text.Trim()) ||
            //                 t1.Address1.Contains(txtSearch.Text.Trim()) ||
            //                 t1.Address2.Contains(txtSearch.Text.Trim()) ||
            //                 t1.State.Contains(txtSearch.Text.Trim()) ||
            //                 t1.Zip.Contains(txtSearch.Text.Trim()) ||
            //                 t1.Country.Contains(txtSearch.Text.Trim()) ||
            //                 t1.Currency.Contains(txtSearch.Text.Trim()) ||
            //                 t1.WebsiteUrl.Contains(txtSearch.Text.Trim()) ||
            //                 t1.Question.Contains(txtSearch.Text.Trim()) ||
            //                 t1.Answer.Contains(txtSearch.Text.Trim()) ||
            //                 t1.AffiliateCode.Contains(txtSearch.Text.Trim()))

            //                select new
            //                {
            //                    t1.UserId,
            //                    t1.FirstName,
            //                    t1.LastName,
            //                    t1.CompanyName,
            //                    t1.ContactPhone,
            //                    t1.CellPhone,
            //                    t1.SkypeName,
            //                    t1.Address1,
            //                    t1.Address2,
            //                    t1.State,
            //                    t1.Zip,
            //                    t1.Country,
            //                    t1.Currency,
            //                    t1.WebsiteUrl,
            //                    t1.Question,
            //                    t1.Answer,
            //                    t1.AffiliateCode,
            //                    t2.CreateDate,
            //                    GetAmountAff = GetAmountAff(new Guid(t1.UserId.Value.ToString())),
            //                    AmountPartnerCommission = t1.CommissionPartner,
            //                }).OrderByDescending(ui => ui.GetAmountAff).ToList();
             return View();

           
            Guid g;

        }
        public void Yes() {
            //   db.BookMasters.Select(u =>new BookMaster() { strBookTypeId= new Guid(u.strBookTypeId).ToString() });
            var d = from c in db.BookMasters select new   { c.strBookTypeId};
            var e = from c in db.BookMasters select new { strBookTypeId = "" };
            var r = from c in db.BookMasters select new { strBookTypeId = new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709").ToString() };
            RedirectToAction("GG");
            //var d=     from c in db.BookMasters select new  { strBookTypeId = new Guid(c.strBookTypeId).ToString() };
        }
        [HttpPost]
        public void GG() {
            Content("success");
        }
        private object GetAmountAff(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}