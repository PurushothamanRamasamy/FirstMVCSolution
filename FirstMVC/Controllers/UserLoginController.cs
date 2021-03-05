using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class UserLoginController : Controller
    {
        DbReleaseManagement db = new DbReleaseManagement();
        public ActionResult SelectCities()
        {
            Address address = new Address();
            return View(address);
        }
        [HttpPost]
        public string SelectCities(Address address)
        {
            return address.SelectedCity;
        }
        // GET: UserLogin
        public ActionResult Index()
        {
            List<SelectListItem> myCities = new List<SelectListItem>();
            myCities.Add(new SelectListItem() {Text="Agra",Value="AgraCity" });
            myCities.Add(new SelectListItem() { Text = "Chennai", Value = "ChennaiCity" });
            myCities.Add(new SelectListItem() { Text = "Goa", Value = "GoaCity" });
            myCities.Add(new SelectListItem() { Text = "US", Value = "USCity" });
            ViewBag.cites = myCities;

            

            return View();
        }
        [HttpPost]
        public ActionResult Index(Login login)
        {

            LoginDetails data = db.loginDetails.Where(user => user.UserName == login.UserName && user.Password == login.Password).FirstOrDefault();
            //List<LoginDetails > dblogindetails = db.loginDetails.ToList<LoginDetails>();
            /*foreach (var item in dblogindetails)
            {
                if (login.UserName == item.UserName)
                {
                    if(login.Password == item.Password)
                    {
                        ViewBag.Message = "Login Successfull";
                        return RedirectToAction("Index","LoginDetail");
                        //return RedirectToAction("Index");
                        
                    }
                    else
                    {
                        ViewBag.Message = "Incorrect Password";
                    }
                }
                
            }*/

            if(data!=null)
            {
                TempData["UserName"] = login.UserName;
                TempData["Role"] = data.Role;
                return RedirectToAction("Index", "LoginDetail");
            }
            
            

            return View();
        }
    }
}