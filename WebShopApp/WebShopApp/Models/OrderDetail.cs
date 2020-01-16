using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopApp.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public decimal Price { get; set; }


        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ShoppingCartItemId { get; set; }
        public ShoppingCartItem ShoppingCartItem { get; set; }
    }
}
