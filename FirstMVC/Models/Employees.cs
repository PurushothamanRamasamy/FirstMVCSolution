using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FirstMVC.Models
{
    public class Employees
    {
        public int Id{ get; set; }
        public string UserName{ get; set; }
        public string Role{ get; set; }

        [ForeignKey("UserName")]
        public LoginDetails loginDetails { get; set; }
    }
}