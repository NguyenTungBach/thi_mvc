namespace Thi_MVC.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Thi_MVC.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Thi_MVC.Data.ThiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Thi_MVC.Data.ThiContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var products = new List<Product>
            {
                new Product { ProductName = "T-shirt kid UNIQLO",   SupplierId = 1, CategoryId=1, QuantityPerUnit=12, UnitPrice=10000, UnitslnStock=10000,UnitsOnOrder=1000, ReorderLevel=1,Discontinued=1  },
                new Product { ProductName = "Jeans kid UNIQLO", SupplierId =2, CategoryId=2 , QuantityPerUnit=13, UnitPrice=20000, UnitslnStock=20000,UnitsOnOrder=1000, ReorderLevel=2,Discontinued=1},
                new Product { ProductName = "Shoes kid Dolce & Gabbana",   SupplierId = 3, CategoryId=3 , QuantityPerUnit=14, UnitPrice=30000, UnitslnStock=10000,UnitsOnOrder=1000, ReorderLevel=1,Discontinued=1},
                new Product { ProductName = "Suit God Of War",    SupplierId = 4, CategoryId=4, QuantityPerUnit=15, UnitPrice=40000, UnitslnStock=40000,UnitsOnOrder=1000, ReorderLevel=1,Discontinued=0},
            };
            products.ForEach(s => context.Product.AddOrUpdate(s));

            var categories = new List<Category>
            {
                new Category { CategoryName = "T-shirt", Description="ABC1", Picture="Anh1" },
                new Category { CategoryName = "Jeans", Description="ABC2", Picture="Anh2"},
                new Category { CategoryName = "Shoes", Description="ABC3", Picture="Anh3"},
                new Category { CategoryName = "Suit", Description="ABC4", Picture="Anh4"},
            };
            categories.ForEach(s => context.Category.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}
