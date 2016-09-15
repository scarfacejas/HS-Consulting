using HS.Consulting.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HS.Consulting.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ServiceData _serviceData = new ServiceData();
        private const string DEFAULT_VIEW = "Index"; 

        // GET: Services
        public ActionResult Index()
        {
            return Consultancy();
        }

        // GET: Services
        public ActionResult Consultancy()
        {
            ViewBag.Title = "Services - Consultancy";

            return View(DEFAULT_VIEW, _serviceData.GetService("Consultancy"));
        }

        // GET: Services
        public ActionResult TalentAttraction()
        {
            ViewBag.Title = "Services - Talent Attraction";

            return View(DEFAULT_VIEW, _serviceData.GetService("Talent Attraction"));
        }

        // GET: Services
        public ActionResult Engagement()
        {
            ViewBag.Title = "Services - Engagement";

            return View(DEFAULT_VIEW, _serviceData.GetService("Engagement"));
        }

        // GET: Services
        public ActionResult OutsourcedHR()
        {
            ViewBag.Title = "Services - Outsourced HR";

            return View(DEFAULT_VIEW, _serviceData.GetService("Outsourced HR"));
        }

        // GET: Services
        public ActionResult EmployeeBenefits()
        {
            ViewBag.Title = "Services - Employee Benefits";

            return View(DEFAULT_VIEW, _serviceData.GetService("Employee Benefits"));
        }

        // GET: Services
        public ActionResult Training()
        {
            ViewBag.Title = "Services - Training";

            return View(DEFAULT_VIEW, _serviceData.GetService("Training"));
        }
    }
}