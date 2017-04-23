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

            //var users = new User[]
            //{
            //    new User { Username ="example",Password="sdfasdf",Permission="customer"},
            //    new User { Username ="example2",Password="sdfasdfsdf",Permission="admin"},
            //};
            //foreach (User s in users)
            //{
            //    context.Users.Add(s);
            //}
            //context.SaveChanges();

            var bags = new Bag[]
            {
                new Bag { BagName ="qwe",Color="green",Price=99,Quantity=5},
                new Bag { BagName ="qer",Color="red",Price=199,Quantity=35}
            };
            foreach (Bag s in bags)
            {
                context.Bags.Add(s);
            }
            context.SaveChanges();

            var categories = new Category[]
            {
                new Category { CateName="women" },
                new Category { CateName="men" }
            };
            foreach (Category s in categories)
            {
                context.Categories.Add(s);
            }
            context.SaveChanges();

        }
    }
}
