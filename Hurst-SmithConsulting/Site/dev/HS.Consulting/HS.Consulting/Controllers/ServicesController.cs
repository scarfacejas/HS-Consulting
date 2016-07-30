using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HS.Consulting.Controllers
{
    public class ServicesController : ControllerBase
    {
        public override string MainImage
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        // GET: Services
        public ActionResult Index()
        {
            return View();
        }

        // GET: Services
        public ActionResult TalentAttraction()
        {
            return View();
        }

        // GET: Services
        public ActionResult Engagement()
        {
            return View();
        }

        // GET: Services
        public ActionResult OutsourceHR()
        {
            return View();
        }

        // GET: Services
        public ActionResult EmploymentBenefits()
        {
            return View();
        }

        // GET: Services
        public ActionResult Training()
        {
            return View();
        }
    }
}