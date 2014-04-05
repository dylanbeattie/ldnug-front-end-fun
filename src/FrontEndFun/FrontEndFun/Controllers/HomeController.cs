using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEndFun.Controllers {
    public class HomeController : Controller {
        //
        // GET: /Home/

        public ActionResult Index() {
            return View();
        }

        public ActionResult Styles() {
            return (View());
        }

        public ActionResult Coffee() {
            return (View());
        }
    }
}
