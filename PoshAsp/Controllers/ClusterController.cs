﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PoshAsp.Models;

namespace PoshAsp.Controllers
{
    public class ClusterController : Controller
    {
        // GET: Cluster
        [Authorize] public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(string id)
        {
            return View(model:id);
        }

        public ActionResult History()
        {
            return View(new LogEntries("clusterlog"));
        }
    }
}