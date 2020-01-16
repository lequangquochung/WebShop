using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Price { get; set; }
        public string ImageUrl { get; set; }
        public string IsProductHot { get; set; }
        public string InStock { get; set; }

        public int BrandId { get; set; }
        public Brand Brands { get; set; }


        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
