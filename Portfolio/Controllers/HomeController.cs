using ObjectModel;
using ObjectModel.Helpers;
using Portfolio.ViewModels.Layout;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    using System.Net.Mail;
    using System.Web.UI.WebControls;

    using Portfolio.ViewModels;

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewCV()
        {
            return this.View();
        }

        public FileResult DownloadCv()
        {
            return File("~/Content/cv.pdf", "application/pdf", "CV.pdf");  
        }

        public ActionResult Contact()
        {
            return View("Contact", new ContactViewModel());
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                SendContactMail(model.YourMail, model.YourMessage);
            }
            
            return this.View();
        }

        private void SendContactMail(string from, string content)
        {
            try
            {
                var mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(from);
                mail.To.Add("stephane.miginiac@gmail.com");
                mail.Subject = "Message from : " + from;
                mail.Body = content;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("stephmigi.portfolio@gmail.com", "halflife#A");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                throw ex;

                // to do
            }
        }
    }
}
