using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week6CodeChallenge.Controllers
{
    public class HomeController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
                return PartialView();

            return View();
        }

        public ActionResult About()
        {
            return PartialView();
        }

        public ActionResult Careers()
        {
            return PartialView();
        }

        public ActionResult Contact()
        {
            return PartialView();
        }

        public ActionResult Work()
        {
            return PartialView();
        }

    }
}