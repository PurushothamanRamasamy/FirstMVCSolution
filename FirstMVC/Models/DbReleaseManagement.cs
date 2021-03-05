using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstMVC.Models
{
    public class DbReleaseManagement:DbContext
    {
        public DbReleaseManagement():base("conRM")
        {
            
        }
        public DbSet<Employees> employees { get; set; }
        public DbSet<LoginDetails> loginDetails { get; set; }
    }
}