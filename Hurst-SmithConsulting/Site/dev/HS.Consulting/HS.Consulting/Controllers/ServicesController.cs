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
            ViewBag.MetaDescription = "HR and talent consultancy for small to medium sized businesses.";

            return View(DEFAULT_VIEW, _serviceData.GetService("Consultancy"));
        }

        // GET: Services
        public ActionResult TalentAttraction()
        {
            ViewBag.Title = "Services - Talent Attraction";
            ViewBag.MetaDescription = "HR and talent consultancy for small to medium sized businesses, specialists in talent attraction and retention.";

            return View(DEFAULT_VIEW, _serviceData.GetService("Talent Attraction"));
        }

        // GET: Services
        public ActionResult Engagement()
        {
            ViewBag.Title = "Services - Engagement";
            ViewBag.MetaDescription = "HR and talent consultancy for small to medium sized businesses. Engaging staff is critical to morale and your bottom line.";

            return View(DEFAULT_VIEW, _serviceData.GetService("Engagement"));
        }

        // GET: Services
        public ActionResult OutsourcedHR()
        {
            ViewBag.Title = "Services - Outsourced HR";
            ViewBag.MetaDescription = "HR and talent consultancy for small to medium sized businesses. Tailored by client needs, we take care of all HR initiatives.";

            return View(DEFAULT_VIEW, _serviceData.GetService("Outsourced HR"));
        }

        // GET: Services
        public ActionResult EmployeeBenefits()
        {
            ViewBag.Title = "Services - Employee Benefits";
            ViewBag.MetaDescription = "HR and talent consultancy for small to medium sized businesses. We create bespoke and flexible packages that can be adapted with your changing business.";

            return View(DEFAULT_VIEW, _serviceData.GetService("Employee Benefits"));
        }

        // GET: Services
        public ActionResult Training()
        {
            ViewBag.Title = "Services - Training";
            ViewBag.MetaDescription = "HR and talent consultancy for small to medium sized businesses. We research, organise and conduct your staff's training needs.";

            return View(DEFAULT_VIEW, _serviceData.GetService("Training"));
        }
    }
}