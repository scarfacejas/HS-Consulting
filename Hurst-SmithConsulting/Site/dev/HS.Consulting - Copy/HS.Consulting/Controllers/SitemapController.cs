using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HS.Consulting.Controllers
{
    public class SitemapController : ControllerBase
    {
        public override string MainImage
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        // GET: Sitemap
        public ActionResult Index()
        {
            return View();
        }
    }
}