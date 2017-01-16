using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspNetMVC;
using System.Web.Helpers;
using System.Web.UI.DataVisualization.Charting;
using System.Drawing;
using System.IO;
//using System.Web.Helpers;

namespace AspNetMVC.Controllers
{
    public class MVC0113Controller : Controller
    {
        private CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();

        // GET: MVC0113
        public ActionResult Index()
        {
            return View(db.BookMasters.ToList());
        }
        //[HttpPost]
        //string chartkey = "0", string chartType = "bar"
        public PartialViewResult _GetChartImage(string chartkey = "0", string chartType = "bar")
        {
            ViewBag.chartkey = chartkey;
            ViewBag.chartType = chartType;
            return PartialView();
        }
        public class StatusNumber
        {
            public string Status { get; set; }

            public string Number { get; set; }
        }     
        public ActionResult CreatePieChart(string chartkey, string chartType)
        {

            //string[] h =
            //    db.BookMasters..strBookTypeId
            //if (id == "0")
            //{
            //}
            var chart = new System.Web.UI.DataVisualization.Charting.Chart();
            var statusNumbers = new List<StatusNumber>
 {
 new StatusNumber{Number="17968", Status="USA"},
 new StatusNumber{Number="11385", Status="China"},
 new StatusNumber{Number="4116", Status="Japan"},
 new StatusNumber{Number="3371", Status="Germany"},
 new StatusNumber{Number="2865", Status="UK"},
 new StatusNumber{Number="2423", Status="France"},
 new StatusNumber{Number="2183", Status="India"},
 };



            chart.Width = 350;

            chart.Height = 400;

            chart.BackColor = Color.FromArgb(211, 223, 240);

            chart.BorderlineDashStyle = ChartDashStyle.Solid;

            chart.BackSecondaryColor = Color.White;

            chart.BackGradientStyle = GradientStyle.TopBottom;

            chart.BorderlineWidth = 1;

            chart.Palette = ChartColorPalette.BrightPastel;

            chart.BorderlineColor = Color.FromArgb(26, 59, 105);

            chart.RenderType = RenderType.BinaryStreaming;

            chart.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;

            chart.AntiAliasing = AntiAliasingStyles.All;

            chart.TextAntiAliasingQuality = TextAntiAliasingQuality.Normal;

            chart.Titles.Add(CreateTitle());

            chart.Legends.Add(CreateLegend());

            chart.Series.Add(CreateSeries(SeriesChartType.Bar, statusNumbers));

            chart.ChartAreas.Add(CreateChartArea());
            //var chart = new System.Web.Helpers.Chart(width: 300, height: 200);

            //var chart = new System.Web.Helpers.Chart(width: 300, height: 200)
            //    .AddTitle("Chart1")
            //    .AddSeries(
            //    //chartType: "bar",
            //    chartType: "bar",
            //    //xValue: new[] { "10 records", "20 records", "30 records", "40 records" },
            //    //yValues: new[] { "50", "60", "70", "80" },axisLabel: "c,c,c,c"

            //    yValues: new[] { "50" }, axisLabel: "500"

            //    )
            //    .GetBytes("png");
            MemoryStream ms = new MemoryStream();
            chart.SaveImage(ms);
            // FileStream dumpFile = new FileStream(@"C:\Users\v-tiguo\Pictures\Dump.jpg", FileMode.Create, FileAccess.ReadWrite);
            // ms.WriteTo(dumpFile);
            // ms.Close();
            // dumpFile.Seek(0, SeekOrigin.Begin);

            //byte[] a= { 1,2};
            //ms.Write(a, 0, 10000);
            ms.Seek(0, SeekOrigin.Begin);
            //return File(dumpFile, @"image/png");
            return File(ms, @"image/png");
            //  return File(chart, "image/png");


        }
        public Title CreateTitle()

        {

            Title title = new Title

            {

                Text = "GDP Current Prices in Billion($)",

                ShadowColor = Color.FromArgb(32, 0, 0, 0),

                Font = new Font("Trebuchet MS", 14F, FontStyle.Bold),

                ShadowOffset = 3,

                ForeColor = Color.FromArgb(26, 59, 105)

            };




            return title;

        }
        public Series CreateSeries(SeriesChartType chartType, ICollection<StatusNumber> list)
        {
            var series = new Series
            {
                Name = "GDP Current Prices in Billion($)",
                IsValueShownAsLabel = true,//display label text value
                Color = Color.FromArgb(198, 99, 99),
                ChartType = chartType,
                BorderWidth = 2
            };
            foreach (var item in list)
            {
                var point = new DataPoint
                {
                    AxisLabel = item.Status,
                    YValues = new double[] { double.Parse(item.Number) }
                };
                series.Points.Add(point);
            }
            return series;
        }
        public ChartArea CreateChartArea()

        {

            var chartArea = new ChartArea();

            chartArea.Name = "GDP Current Prices in Billion($)";

            chartArea.BackColor = Color.Transparent;

            chartArea.AxisX.IsLabelAutoFit = false;

            chartArea.AxisY.IsLabelAutoFit = false;

            chartArea.AxisX.LabelStyle.Font = new Font("Verdana,Arial,Helvetica,sans-serif", 8F, FontStyle.Regular);

            chartArea.AxisY.LabelStyle.Font = new Font("Verdana,Arial,Helvetica,sans-serif", 8F, FontStyle.Regular);

            chartArea.AxisY.LineColor = Color.FromArgb(64, 64, 64, 64);

            chartArea.AxisX.LineColor = Color.FromArgb(64, 64, 64, 64);

            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);

            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);

            chartArea.AxisX.Interval = 1;




            return chartArea;

        }
        
        public Legend CreateLegend()

        {

            var legend = new Legend

            {

                Name = "GDP Current Prices in Billion($)",

                Docking = Docking.Bottom,

                Alignment = StringAlignment.Center,

                BackColor = Color.Transparent,

                Font = new Font(new FontFamily("Trebuchet MS"), 9),

                LegendStyle = LegendStyle.Row

            };




            return legend;
        }
        #region orengin
            // GET: MVC0113/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookMaster bookMaster = db.BookMasters.Find(id);
            if (bookMaster == null)
            {
                return HttpNotFound();
            }
            return View(bookMaster);
        }

        // GET: MVC0113/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MVC0113/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,strBookTypeId,strAccessionId")] BookMaster bookMaster)
        {
            if (ModelState.IsValid)
            {
                db.BookMasters.Add(bookMaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookMaster);
        }

        // GET: MVC0113/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookMaster bookMaster = db.BookMasters.Find(id);
            if (bookMaster == null)
            {
                return HttpNotFound();
            }
            return View(bookMaster);
        }

        // POST: MVC0113/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,strBookTypeId,strAccessionId")] BookMaster bookMaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookMaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookMaster);
        }

        // GET: MVC0113/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookMaster bookMaster = db.BookMasters.Find(id);
            if (bookMaster == null)
            {
                return HttpNotFound();
            }
            return View(bookMaster);
        }

        // POST: MVC0113/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookMaster bookMaster = db.BookMasters.Find(id);
            db.BookMasters.Remove(bookMaster);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion
    }
}
