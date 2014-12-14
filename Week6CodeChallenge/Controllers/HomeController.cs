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

        [HttpGet]
        public ActionResult Contact()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Contact(Models.Week6Contacts contact)
        {
            Models.sp5ReidEntities1 db = new Models.sp5ReidEntities1();

            db.Week6Contacts.Add(contact);
            db.SaveChanges();

            return Content("Thank you for contacting us!");
        }

        public ActionResult Work()
        {
            return PartialView();
        }

    }
}