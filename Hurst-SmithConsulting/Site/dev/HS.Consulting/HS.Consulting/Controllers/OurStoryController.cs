using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HS.Consulting.Controllers
{
    public class OurStoryController : Controller
    {
        // GET: OurStory
        public ActionResult Index()
        {
            return Approach();
        }

        public ActionResult Approach()
        {
            ViewBag.Title = "Our Story - Approach";
            ViewBag.MetaDescription = "HR and talent consultancy for small to medium sized businesses. Our approach to our HR and people journey.";
            ViewBag.OurStoryPartialView = "_ApproachPartialView";

            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Title = "Our Story - About Niki";
            ViewBag.MetaDescription = "HR and talent consultancy for small to medium sized businesses. The story of our HR and people journey.";
            ViewBag.OurStoryPartialView = "_AboutPartialView";

            return View("Index");
        }

        public ActionResult Partners()
        {
            ViewBag.Title = "Our Story - Partners";
            ViewBag.MetaDescription = "HR and talent consultancy for small to medium sized businesses. Our partners on our HR and people journey.";
            ViewBag.OurStoryPartialView = "_PartnersPartialView";

            return View("Index");
        }
    }
}