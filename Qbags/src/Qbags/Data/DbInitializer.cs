using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Qbags.Models;

namespace Qbags.Data
{
    public class DbInitializer
    {
        public static void Initialize(BagContext context)
        {
            context.Database.EnsureCreated();
            if (context.Users.Any())
            {
                return;
            }

            var users = new User[]
            {
                new User { Username ="example",Password="sdfasdf",Permission="customer"},
                new User { Username ="example2",Password="sdfasdfsdf",Permission="admin"},
            };
            foreach (User s in users)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();

            var categories = new Category[]
            {
                new Category {Name = "Men", Description="subcate" },
                new Category {Name = "Women", Description="subcate" }
            };

            foreach (Category s in categories)
            {
                context.Categories.Add(s);
            }
            context.SaveChanges();

            var suppliers = new Supplier[]
            {
                new Supplier {Name = "wang", Phone="027888888" },
                new Supplier {Name = "zhang", Phone="021888888" }
            };


            foreach (Supplier s in suppliers)
            {
                context.Suppliers.Add(s);
            }
            context.SaveChanges();

            var bags = new Bag[]
            {
                new Bag { BagName ="qwe",Color="green",Price=99,Quantity=5, Discount=0.9, Brand="LK",Description="12345",SupplierID=1,CategoryID=1},
                new Bag { BagName ="qer",Color="red",Price=199,Quantity=35, Discount=0.9, Brand="LK",Description="12345",SupplierID=1,CategoryID=2}
            };
            foreach (Bag s in bags)
            {
                context.Bags.Add(s);
            }
            context.SaveChanges();



            var orders = new Order[]
            {
                new Order {UserID = 1, Status = OrderStatus.Paid, Subtotal = 99, Total = 105 },
            };
            foreach (Order s in orders)
            {
                context.Orders.Add(s);
            }
            context.SaveChanges();



            var orderitems = new OrderItem[]
            {
                new OrderItem {OrderID = 1, BagID = 2, Quantity = 2}
            };
            foreach (OrderItem s in orderitems)
            {
                context.OrderItems.Add(s);
            }
            context.SaveChanges();
        }
    }
}
