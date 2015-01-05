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

    using Portfolio.ViewModels;

    public class HomeController : BaseController
    {
        public HomeController()
        {
            @ViewBag.Active = "Home";
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View("Contact", new ContactViewModel());
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel model)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress(model.YourMail);
            mail.To.Add("stephane.miginiac@gmail.com");
            mail.Subject = "Message from : " + model.YourMail;
            mail.Body = model.YourMessage;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("stephmigi.portfolio@gmail.com", "halflife#A");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

            return this.View();
        }
    }
}
