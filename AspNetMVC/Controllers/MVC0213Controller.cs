using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0213Controller : Controller
    {
        // GET: MVC0213
        public ActionResult Index()
        {
            ViewBag.FormSubmit = true;

            return View();
        }
        public async Task<ActionResult> Contact(EmailFormModel model)
        {
            if (true)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("name@gmail.com")); //replace with valid value
                message.Subject = "Your email subject";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;
                //using (var smtp = new SmtpClient())
                {
                    await Task.Delay(1000);
                    //await smtp.SendMailAsync(message);
                    return View();
                }
            }
            return View(model);
        }
    }
}