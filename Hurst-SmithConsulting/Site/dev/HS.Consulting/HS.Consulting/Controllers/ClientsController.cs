﻿using HS.Consulting.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HS.Consulting.Controllers
{
    public class ClientsController : Controller
    {
        // GET: Clients
        public ActionResult Index()
        {
            ViewBag.Title = "Clients";
            ViewBag.MetaDescription = "HR and talent consultancy for small to medium sized businesses. Here's a list of some of our clients and what they had to say.";

            return View();
        }
    }
}