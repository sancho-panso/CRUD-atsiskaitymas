using Crud.App.Data;
using Crud.App.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crud.App.Services
{
    public class OrderService : IOrderService
    {
        private readonly Context _context;

        public OrderService(Context context)
        {
            _context = context;
        }
        public void Create()
        {
            Order order = new Order();
            order.OrderData = DateTime.Now;
            Console.WriteLine("Please enter Order number");
            order.OrderNumber = Console.ReadLine();
            Console.WriteLine("Please enter Client name");
            string clientName = Console.ReadLine();
            Client client = _context.Clients.Where(c => c.Name == clientName)
                                            .Include(client=>client.DeliveryAdress).FirstOrDefault();
            order.Client = client;
            order.DeliveryAdress = client.DeliveryAdress;
            _context.Add(order);
            _context.SaveChanges();

        }

        public void Delete(Guid? id)
        {
            var order = _context.Orders.Where(o => o.OrderID == id).FirstOrDefault();
            _context.Remove(order);
            _context.SaveChanges();
        }

        public void Edit(Guid id)
        {
            var order = _context.Orders.Where(o => o.OrderID == id).FirstOrDefault();
            order.OrderData = DateTime.Now;
            Console.WriteLine("Please enter Order number");
            order.OrderNumber = Console.ReadLine();
            Console.WriteLine("Please enter Client name");
            string clientName = Console.ReadLine();
            Client client = _context.Clients.Where(c => c.Name == clientName)
                                            .Include(client => client.DeliveryAdress).FirstOrDefault();
            order.Client = client;
            order.DeliveryAdress = client.DeliveryAdress;
            _context.Add(order);
            _context.SaveChanges();
        }

        public void Read(string name)
        {
            var order = _context.Orders.Where(o => o.OrderNumber == name)
                                       .Include(o => o.Client)
                                       .Include(o=>o.OrderedItems)
                                       .ThenInclude(i=>i.Item).FirstOrDefault();
            Console.WriteLine("Order date");
            Console.WriteLine(order.OrderData); ;
            Console.WriteLine("Client name");
            Console.WriteLine(order.Client.Name);
            Console.WriteLine("Ordered Items");
            foreach (var item in order.OrderedItems)
            {
                Console.WriteLine(item.Item.ItemName);
            }

        }

    }
}
