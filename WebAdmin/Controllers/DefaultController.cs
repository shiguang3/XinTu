﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service;

namespace WebAdmin.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            AdminService adminService = new AdminService();
            adminService.A();
            return View();
        }
    }
}