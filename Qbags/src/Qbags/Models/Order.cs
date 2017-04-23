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
        public int Sum { get; set; }
        public ICollection<Orderbag> Orderbags { get; set; }
        public User User { get; set; }
    }
}
