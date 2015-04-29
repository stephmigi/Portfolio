using System;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    using System.Collections.Generic;
    using System.Net.Mail;

    using DotNet.Highcharts;
    using DotNet.Highcharts.Enums;
    using DotNet.Highcharts.Helpers;
    using DotNet.Highcharts.Options;

    using Portfolio.ViewModels;

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var technicalCompetences = new string[] { "C#", "SQL", "PHP", "Orchard", "C", "HTML/CSS", "Git/SVN" };
            var technicalCompetencesRating = new object[] { 8, 7, 9, 6, 8, 9, 7 };

            var humanCompetences = new string[]
                                       {
                                           "Communication", "Autonomie", "Anglais", "Gestion de projet",
                                           "Formation"
                                       };
            var humanCompetencesRating = new object[] { 8, 9, 9, 6, 7 };

            var chartHumanCompetences = this.GeneratePolarRadarChart("chartHumanCompetences", "Compétences humaines", humanCompetences, humanCompetencesRating);
            var chartTechnicalCompetences = this.GeneratePolarRadarChart("chartTechnicalCompetences", "Compétences techniques",technicalCompetences, technicalCompetencesRating);

            var vm = new HomeIndexViewModel(chartHumanCompetences, chartTechnicalCompetences);

            return View(vm);
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

        private Chart BuildChart()
        {
            var chart = new Chart { Type = ChartTypes.Line, Polar = true };
            return chart;
        }

        private Highcharts GeneratePolarRadarChart(string name, string displayName, string[] categories, object[] values)
        {
            var chart2 = new Highcharts(name).InitChart(new Chart { DefaultSeriesType = ChartTypes.Column })
            .InitChart(new Chart
            {
                Width = 410,
                Polar = true,
                Type = ChartTypes.Line
            })
            .SetTitle(new Title
            {
                Text = displayName,
                X = 0,
                Style = "color: '#000', font: '20px Helvetica'"
            })
            .SetXAxis(new XAxis
            {
                Categories = categories,
                Labels = new XAxisLabels
                             {
                                 Style = "color: '#000', font: '11px Helvetica'"
                             }
            })
            .SetYAxis(new YAxis
            {
                GridLineInterpolation = "polygon",
                LineWidth = 0,
                Min = 0,
                Labels = new YAxisLabels
                {
                    Enabled = false
                }
            })
            .SetLegend(new Legend
                           {
                               Enabled = false
                           })
            .SetExporting(new Exporting { Enabled = false })
            .SetSeries(new[]
            {
                new Series
                {
                    Name = "Note sur 10",
                    Data = new Data(values)                 
                },
            });

            return chart2;
        }
    }
}
