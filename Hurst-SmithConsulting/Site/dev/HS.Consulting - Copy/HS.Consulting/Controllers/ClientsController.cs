using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HS.Consulting.Controllers
{
    public class ClientsController : ControllerBase
    {
        public override string MainImage
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        // GET: Clients
        public ActionResult Index()
        {
            return View();
        }
    }
}