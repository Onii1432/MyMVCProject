﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjet.Controllers
{
    public class MasterCtrlController : Controller
    {
        // GET: MasterCtrl
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index1()
        {
            return View();
        }

        
        //====
        public class ListModel3
        {

            public int ID { get; set; }

        }

        public class ListModel2
        {

            public int ID { get; set; }

        }
    }
}