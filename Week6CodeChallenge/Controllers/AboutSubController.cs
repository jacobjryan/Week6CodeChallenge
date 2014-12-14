using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week6CodeChallenge.Controllers
{
    public class AboutSubController : Controller
    {
        // GET: AboutSub
        public ActionResult Who()
        {
            return PartialView();
        }

        public ActionResult What()
        {
            return PartialView();
        }

        public ActionResult Why()
        {
            return PartialView();
        }

        public ActionResult How()
        {
            return PartialView();
        }

        public ActionResult Where()
        {
            return PartialView();
        }
    }
}