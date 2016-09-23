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
            ViewBag.Title = "Our Story - Approach";
            ViewBag.MetaDescription = "HR and talent consultancy for small to medium sized businesses. The story of our HR and people journey.";

            return View();
        }

        public PartialViewResult Approach()
        {
            ViewBag.Title = "Our Story - Approach";

            return PartialView("_ApproachPartialView");
        }

        public PartialViewResult About()
        {
            ViewBag.Title = "Our Story - About Niki";

            return PartialView("_AboutPartialView");
        }

        public PartialViewResult Partners()
        {
            ViewBag.Title = "Our Story - Partners";

            return PartialView("_PartnersPartialView");
        }
    }
}