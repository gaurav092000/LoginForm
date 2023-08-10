using LoginForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginForm.Controllers
{
    public class LoginController : Controller
    {
        // GET: Home
       UserContext db=new UserContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User u)
        {
            var crediatial = db.Users.Where(model => model.UserName == u.UserName && model.Password == u.Password).FirstOrDefault();
            if(crediatial !=null)
            {
                Session["ID"]=u.Id.ToString();
                Session["data"]=u.UserName.ToString();
                TempData["LoginSuccess"] = "<script>alert('Login Successfull')</script>";
                return RedirectToAction("Index","User");
            }
            else
            {
                TempData["LoginSuccess"] = "<script>alert('Login Failed')</script>";
            return View();
            }
        }


        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(User u)
        {
            if(ModelState.IsValid==true)
            {
                db.Users.Add(u);
                int a=db.SaveChanges();
                if(a > 0)
                {
                    TempData["signup"] = "<script>alert('Resistration Successfull')</script>";
                    ModelState.Clear();
                }
                else
                {
                    TempData["signup"] = "<script>alert('Not Resistration ')</script>";
                }
            }

            return View();
        }
    }
}