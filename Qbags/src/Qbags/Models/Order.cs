using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qbags.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public OrderStatus Status { get; set; }
        public int Subtotal { get; set; }
        public int Total { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
        public User User { get; set; }
    }
}
