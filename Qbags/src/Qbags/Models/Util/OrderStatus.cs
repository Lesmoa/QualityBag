using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qbags.Models.Util
{
    public enum OrderStatus
    {
        Unpaid = 0,
        Paid,
        Shipped,
        Finished,
        Cancelled
    }
}
