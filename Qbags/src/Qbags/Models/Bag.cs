using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qbags.Models
{
    public class Bag
    {
        public int ID { get; set; }
        public string BagName { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }

        public Supplier supplier { get; set; }
        public Category Category { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
