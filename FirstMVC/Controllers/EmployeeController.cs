using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmployeeDetails()
        {
            Employee employee = new Employee(3001,"Purushothaman",23,"934789121");
            return View(employee);
        }
    }
}