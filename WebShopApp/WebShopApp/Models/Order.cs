using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public bool OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public float OrderTotal { get; set; }


        public string UserId { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        


    }
}
