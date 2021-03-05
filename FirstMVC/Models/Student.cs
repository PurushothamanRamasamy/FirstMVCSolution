﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVC.Models
{
    public class Student
    {
        public Student()
        {

        }
        public Student(int id,string name,int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public int Id{ get; set; }
        public string Name { get; set; }
        public int Age{ get; set; }
    }
}