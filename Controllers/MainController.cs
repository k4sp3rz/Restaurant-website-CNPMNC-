﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNPM_NC.Controllers
{
    public class mainController : Controller
    {
        // GET: main
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Menu()
        {
            return View();
        }
    }
}