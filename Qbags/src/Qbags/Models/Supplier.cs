using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qbags.Models
{
    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public ICollection<Bag> Bags { get; set; }
    }
}
