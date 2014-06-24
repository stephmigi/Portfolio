using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class BaseController : Controller
    {
        public readonly string ActiveController;

        public BaseController()
        {
            ActiveController = System.Web.HttpContext.Current.Request.RequestContext.RouteData.Values["controller"].ToString();
        }

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);
            this.SetThreadCulture();
        }

        protected void CreateCookie(string key, string value)
        {
            Response.Cookies.Remove(key);

            HttpCookie newCookie = System.Web.HttpContext.Current.Request.Cookies[key];
            if (newCookie == null) newCookie = new HttpCookie(key);
            newCookie.Value = value;
            newCookie.Expires = DateTime.Now.AddDays(10);

            Response.SetCookie(newCookie);
        }

        private void SetThreadCulture()
        {
            HttpCookie languageCookie = System.Web.HttpContext.Current.Request.Cookies["Language"];
            if (languageCookie != null)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(languageCookie.Value);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(languageCookie.Value);
            }
        }
    }
}
