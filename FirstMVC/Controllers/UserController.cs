using FirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class UserController : Controller
    {
        DbReleaseManagement db = new DbReleaseManagement();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(LoginDetails loginDetails)
        {
            try
            {
                db.loginDetails.Add(loginDetails);
                db.SaveChanges();
                ViewBag.Message = "User created";
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
            }
            return View();
        }
    }
}