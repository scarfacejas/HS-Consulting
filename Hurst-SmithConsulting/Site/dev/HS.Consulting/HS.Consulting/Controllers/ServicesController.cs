using HS.Consulting.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HS.Consulting.Controllers
{
    public class ServicesController : ControllerBase
    {
        private readonly ServiceData _serviceData = new ServiceData();
        private const string DEFAULT_VIEW = "Index"; 

        public override string MainImage
        {
            get
            {
                return string.Empty;
            }
        }

        // GET: Services
        public ActionResult Index()
        {
            return Consultancy();
        }

        // GET: Services
        public ActionResult Consultancy()
        {
            return View(DEFAULT_VIEW, _serviceData.GetService("Consultancy"));
        }

        // GET: Services
        public ActionResult TalentAttraction()
        {
            return View(DEFAULT_VIEW, _serviceData.GetService("TalentAttraction"));
        }

        // GET: Services
        public ActionResult Engagement()
        {
            return View(DEFAULT_VIEW, _serviceData.GetService("Engagement"));
        }

        // GET: Services
        public ActionResult OutsourceHR()
        {
            return View(DEFAULT_VIEW, _serviceData.GetService("OutsourceHR"));
        }

        // GET: Services
        public ActionResult EmploymentBenefits()
        {
            return View(DEFAULT_VIEW, _serviceData.GetService("EmploymentBenefits"));
        }

        // GET: Services
        public ActionResult Training()
        {
            return View(DEFAULT_VIEW, _serviceData.GetService("Training"));
        }
    }
}