using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace AspNetMVC.Controllers
{
    public class MVC0214Controller : Controller
    {
        // GET: MVC0214
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }
        public JsonResult IsMemberTypeExists(string MemberTypeDescription)
        {
            return Json(!true, JsonRequestBehavior.AllowGet);
        }



        public class MemberType
        {
            [Key]

            public int MemberTypeId { get; set; }

            [Remote("IsMemberTypeExists", "MVC0214", ErrorMessage = "Member Type already exists")]
            public string MemberTypeDescription { get; set; }

        }

       public ActionResult Index3()
        {
            string[] a = new string[] { "000.DGDH.34H", "222.JJ8D", "333.JJ8D", "444.JJ8D", "999.YDH77", "A.383JD", "B.HDJ738", "D.J8829", "Z.78WY8" };
            List<string> d=new List<string>();
            string e1, e2;
            e1 =  "333";
            e2 = "999";
            foreach (string b in a)
            {
              string i=  b.Split('.')[0];
                int c = 0;
                if (int.TryParse(i, out c)) {
                    if (int.Parse(e1)<=c && int.Parse(e2)>=c) {
                        d.Add(b);
                    }
                };
            }

            List<string> d2 = new List<string>();
            string e11, e22;
            e11 = "B";
            e22 = "D";
            foreach (string b in a)
            {
                string i = b.Split('.')[0];
                if (string.CompareOrdinal(e11, i)<=0 && string.CompareOrdinal(e22, i)>=0)
                {
                    d.Add(b);
                }
            }

            //output the result d
            return View();
        }

        [HttpPost]
        public JsonResult Create(MemberType objMemberType)
        { 
            try
            {
                if (ModelState.IsValid)
                {
                    //db.MemberTypes.Add(objMemberType);
                    //db.SaveChanges();
                    return Json(new { success = true });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Json(objMemberType, JsonRequestBehavior.AllowGet);
        }
    }
    //       IList<SSPClientMasterEntity> clientlist = mFactory.GetPartyDetailsFromSSPClientMaster(HttpContext.User.Identity.Name);
    //       IList<CountryEntity> country = mdmFactory.GetCountries(string.Empty, string.Empty);
    //       IList<StateEntity> state = mdmFactory.GetStatesByCountry(string.Empty, string.Empty, string.Empty);

    //       public object DBConnectionMode { get; private set; }

    //       ViewBag.country = country;
    //ViewBag.state = state;
    //ViewBag.Shipper = clientlist; 

    //public List<CountryEntity> GetCountries(string Code, string Name)
    //       {
    //           List<CountryEntity> mEntity = new List<CountryEntity>();
    //           string Query = "select C.COUNTRYID,C.CODE,C.NAME,C.DESCRIPTION,C.BASECURRENCYID " +
    //                           "from SMDM_COUNTRY C Inner Join DataProfileClassWFStates DP on C.STATEID=DP.STATEID Where 1=1 ";
    //           if (!string.IsNullOrEmpty(Code.Trim()))
    //           {
    //               Query = Query + " AND Upper(C.Code) like '%" + Code.ToUpper() + "%'";
    //           }
    //           if (!string.IsNullOrEmpty(Name.Trim()))
    //           {
    //               Query = Query + " AND Upper(C.NAME) like '%" + Name.ToUpper() + "%'";
    //           }
    //           ReadText(DBConnectionMode.FOCiS, Query,
    //               new OracleParameter[] { }
    //           , delegate (IDataReader r)
    //           {
    //               mEntity.Add(DataReaderMapToObject<CountryEntity>(r));
    //           });
    //           return mEntity;
    //       }

    //       private T DataReaderMapToObject<T>(IDataReader r)
    //       {
    //           throw new NotImplementedException();
    //       }

    //       public List<StateEntity> GetStatesByCountry(int CountryId, string Code, string Name)
    //       {
    //           List<StateEntity> mEntity = new List<StateEntity>();
    //           if (CountryId != 0 && CountryId != null)
    //           {
    //               string Query = "Select SUBDIVISIONID,COUNTRYID,CODE,NAME,DESCRIPTION from SMDM_SUBDIVISIONS where COUNTRYID=" + CountryId;
    //               if (!string.IsNullOrEmpty(Code.Trim()))
    //               {
    //                   Query = Query + " AND Upper(Code) like '%" + Code.ToUpper() + "%'";
    //               }
    //               if (!string.IsNullOrEmpty(Name.Trim()))
    //               {
    //                   Query = Query + " AND Upper(NAME) like '%" + Name.ToUpper() + "%'";
    //               }
    //               ReadText(DBConnectionMode.FOCiS, Query,
    //                   new OracleParameter[] { }
    //               , delegate (IDataReader r)
    //               {
    //                   mEntity.Add(DataReaderMapToObject<StateEntity>(r));
    //               });
    //           }
    //           return mEntity;
    //       }
    //       public JsonResult FillCountry()
    //       {
    //           try
    //           {

    //               MDMDataFactory mdmFactory = new MDMDataFactory();
    //               IList<CountryEntity> country = mdmFactory.GetCountries(string.Empty, string.Empty);
    //               if (country != null)
    //               {
    //                   var Countrylist = (
    //                            from items in country
    //                            select new
    //                            {
    //                                Text = items.NAME,
    //                                Value = items.COUNTRYID
    //                            }).Distinct().ToList().OrderBy(x => x.Text);
    //                   return Json(Countrylist, JsonRequestBehavior.AllowGet);
    //                   //return Json(new SelectList(Countrylist, "Value", "Text"));
    //               }
    //               else
    //               {
    //                   return Json(null, JsonRequestBehavior.AllowGet);
    //               }
    //           }
    //           catch (Exception ex)
    //           {
    //               throw ex;
    //           }
    //       }
    //       private void ReadText(object fOCiS, string query, OracleParameter[] oracleParameter, Func<IDataReader, object> p)
    //       {
    //           throw new NotImplementedException();
    //       }
    //   }

    //   internal class MDMDataFactory
    //   {
    //   }
}