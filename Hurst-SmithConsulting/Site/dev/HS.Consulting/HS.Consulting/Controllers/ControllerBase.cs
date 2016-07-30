using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HS.Consulting.Controllers
{
    public abstract class ControllerBase : Controller
    {
        public ControllerBase()
        {
            ViewBag.MainImage = MainImage;
        }

        public abstract string MainImage { get; }
    }
}