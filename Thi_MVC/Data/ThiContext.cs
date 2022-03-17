using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Thi_MVC.Models;

namespace Thi_MVC.Data
{
    public class ThiContext : DbContext
    {
        public ThiContext() : base("name=ThiMVCString")
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}