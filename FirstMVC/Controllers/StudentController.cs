using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public string Index()
        {
            return "Hello world";
        }
        public ActionResult AnotherView()
        {
            ViewData["StudentName"] = "Purushothaman";
            int[] nums = { 1, 23, 14, 45, 78, 65, 23 };
            /*ViewData["Numbers"] = nums;*/
            ViewBag.numbers = nums;
            return View();
        }
        public ActionResult StudentDetails()
        {
            Student student = new Student(101,"Pro",23);
            return View(student);
        }
    }
}