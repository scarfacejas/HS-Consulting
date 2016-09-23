using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HS.Consulting.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.Title = "Contact";
            ViewBag.MetaDescription = "HR and talent consultancy for small to medium sized businesses. Contact us for more information.";

            return View("Contact");
        }
    }
}