using Crud.App.Data;
using Crud.App.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crud.App.Services
{
    public class OrderedItemService : IOrderedItemService
    {
        private readonly Context _context;

        public OrderedItemService(Context context)
        {
            _context = context;
        }
        public void Create(string order)
        {
            OrderedItem orderedItem = new OrderedItem();
            var orderN = _context.Orders.Where(o => o.OrderNumber == order).FirstOrDefault();
            orderedItem.Order = orderN;
            Console.WriteLine("Please enter item code");
            string code = Console.ReadLine();
            Console.WriteLine("Please enter quantity");
            double qnt = Convert.ToDouble(Console.ReadLine());
            var item = _context.Items.Where(i => i.ItemNomNr == code).FirstOrDefault();
            orderedItem.Item = item;
            orderedItem.Price = item.Pricelist_A;
            orderedItem.Ordered_QNT = qnt;
            _context.Add(orderedItem);
            _context.SaveChanges();


        }


        public void Delete(Guid? id)
        {
            var item = _context.OrderedItems.Where(o => o.ID == id).FirstOrDefault();
            _context.Remove(item);
            _context.SaveChanges();
        }

        public void Edit(Guid id)
        {
            var item = _context.OrderedItems.Where(o => o.ID == id).FirstOrDefault();
            Console.WriteLine("Please enter qnt");
            var qnt = (double)Convert.ToDouble(Console.ReadLine());
            item.Ordered_QNT = qnt;
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Read(Guid? id)
        {
            var item = _context.OrderedItems.Where(i => i.ID == id)
                                            .Include(i=>i.Order)
                                            .Include(i=>i.Item).FirstOrDefault();
            Console.WriteLine("Order number");
            Console.WriteLine(item.Order.OrderNumber);
            Console.WriteLine("Item name");
            Console.WriteLine(item.Item.ItemName);
            Console.WriteLine("Ordered qnt");
            Console.WriteLine(item.Ordered_QNT);
            Console.WriteLine("Ordered price");
            Console.WriteLine(item.Price);

        }

    }
}
