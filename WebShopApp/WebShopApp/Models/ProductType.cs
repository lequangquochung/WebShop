using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopApp.Models
{
    public class ProductType
    {
        public int ProductTypeId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public List<Product> Products { get; set; }

    }
}
