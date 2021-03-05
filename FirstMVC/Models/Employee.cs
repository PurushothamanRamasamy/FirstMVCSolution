using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVC.Models
{
    public class Employee
    {
        public Employee()
        {

        }
        public Employee(int id,string name,int age,string num)
        {
            EmpId = id;
            Name = name;
            Age = age;
            Number = num;
        }
        public int EmpId { get; set; }
        public string Name{ get; set; }
        public int Age { get; set; }
        public string Number { get; set; }
    }
}