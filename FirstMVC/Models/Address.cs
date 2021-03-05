using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Models
{
    public class Address
    {
        public List<SelectListItem> myCities = new List<SelectListItem>();
        public Address()
        {
            myCities.Add(new SelectListItem() { Text = "Agra", Value = "AgraCity" });
            myCities.Add(new SelectListItem() { Text = "Chennai", Value = "ChennaiCity" });
            myCities.Add(new SelectListItem() { Text = "Goa", Value = "GoaCity" });
            myCities.Add(new SelectListItem() { Text = "US", Value = "USCity" });
        }
        public string SelectedCity{ get; set; }
    }
}