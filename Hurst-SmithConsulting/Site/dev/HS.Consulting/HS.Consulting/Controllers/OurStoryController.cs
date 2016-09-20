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
            return View();
        }

        public PartialViewResult Approach()
        {
            return PartialView("_ApproachPartialView");
        }

        public PartialViewResult About()
        {
            return PartialView("_AboutPartialView");
        }

        public PartialViewResult Partners()
        {
            return PartialView("_PartnersPartialView");
        }
    }
}