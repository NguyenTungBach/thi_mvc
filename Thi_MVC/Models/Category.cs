using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thi_MVC.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}