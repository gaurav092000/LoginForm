﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginForm.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {

            if (Session["ID"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout() 
        {
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }
    }
}