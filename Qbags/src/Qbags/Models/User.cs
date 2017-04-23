using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qbags.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Permission { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Cart Cart { get; set; }
    }
}
