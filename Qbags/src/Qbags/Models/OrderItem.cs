using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qbags.Models
{
    public class OrderItem
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int BagID { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }
        public Bag Bags { get; set; }
    }
}
