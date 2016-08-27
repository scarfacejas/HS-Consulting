using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HS.Consulting.Controllers
{
    public class ContactController : ControllerBase
    {
        public override string MainImage
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
    }
}