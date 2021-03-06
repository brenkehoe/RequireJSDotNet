﻿using System.Collections.Generic;
using System.Web.Mvc;

namespace RequireJsNet.Docs.Controllers
{
    [SessionState(System.Web.SessionState.SessionStateBehavior.ReadOnly)]
    public class HomeController : PublicController
    {
        public ActionResult Index()
        {
            RequireJsOptions.Add("ids", new List<int> { 1, 2, 3 });
            RequireJsOptions.Add("successMsg", "All the modules have been loaded");
 
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            RequireJsOptions.Add("email", "contact@stefanprodan.eu");

            return View();
        }

        public ActionResult Inbox()
        {
            return View();
        }
    }
}
