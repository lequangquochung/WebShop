using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopApp.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string UrlImage { get; set; }
        public List<Product> Products { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
