using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test;
using test.Entities;
using WebApplication1.Entities;
using WebApplication1.ViewModels;

namespace WebApplication1.Services
{
    public class MyService
    {
        public MyService()
        {
          
        }

        public List<Item> GetItems()
        {
            var list = new List<Item>();
            using (MainContext context = new MainContext())
            {
                list = context.Items.ToList();
            }
            return list;
        }

        public List<Order> GetOrders()
        {
            var list = new List<Order>();
            using (MainContext context = new MainContext())
            {
                list = context.Orders.ToList();
            }
            return list;
        }


        public void NewOrder(NewOrderViewModel model)
        {
            var newOrder = new Order(model);
            
            using (MainContext context = new MainContext())
            {
                var driver = context.Clients.Where(x => x.Id == model.ClientId).FirstOrDefault();
                if (driver.Orders.Any(x=>x.DateBegin == model.DateBegin && x.Status!= Status.New && x.Status != Status.Approved))
                {
                    throw new Exception("This driver can`t take your order!");
                }
                context.Orders.Add(newOrder);
            }
        }
    }
}
