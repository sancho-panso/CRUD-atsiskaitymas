using Crud.App.Data;
using Crud.App.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crud.App.Services
{
    public class ItemService : I_itemService
    {
        private readonly Context _context;

        public ItemService(Context context)
        {
            _context = context;
        }
        public void Create()
        {
            Item item = new Item();
            var data = ItemsInput();
            item.ItemNomNr = data["code"];
            item.ItemName = data["name"];
            item.ItemNameEN = data["nameEN"];
            item.ItemNameRU = data["nameRU"];
            Console.WriteLine("Please choose measure units");
            item.Measure = (Measures)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose package type");
            item.Package = (Packages)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose item type");
            item.Type = (Types)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Pricelist A price");
            item.Pricelist_A = (double)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Pricelist B price");
            item.Pricelist_B = (double)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Pricelist C price");
            item.Pricelist_C = (double)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Pricelist D price");
            item.Pricelist_D = (double)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Wharehouse qnt");
            item.WharehouseQNT = (double)Convert.ToInt32(Console.ReadLine());
            item.ModifiedDate = DateTime.Now;
            Console.WriteLine("Please enter Parent Group Name");
            string groupName = Console.ReadLine();
            if (groupName != null)
            {
                var parent = _context.ItemsGroups.Where(g => g.ItemsGroupName == groupName).FirstOrDefault();
                item.ItemsGroup = parent;
            }
            _context.Add(item);
            _context.SaveChanges();

        }

        public void Delete(Guid? id)
        {
            var item = _context.Items.Where(i => i.ItemID == id).FirstOrDefault();
            _context.Remove(item);
            _context.SaveChanges();
        }

        public void Edit(Guid? id)
        {
            var item = _context.Items.Where(i => i.ItemID == id).FirstOrDefault();
            var data = ItemsInput();
            item.ItemNomNr = data["code"];
            item.ItemName = data["name"];
            item.ItemNameEN = data["nameEN"];
            item.ItemNameRU = data["nameRU"];
            Console.WriteLine("Please choose measure units");
            item.Measure = (Measures)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose package type");
            item.Package = (Packages)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose item type");
            item.Type = (Types)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Pricelist A price");
            item.Pricelist_A = (double)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Pricelist B price");
            item.Pricelist_B = (double)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Pricelist C price");
            item.Pricelist_C = (double)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Pricelist D price");
            item.Pricelist_D = (double)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Wharehouse qnt");
            item.WharehouseQNT = (double)Convert.ToInt32(Console.ReadLine());
            item.ModifiedDate = DateTime.Now;
            Console.WriteLine("Please enter Parent Group Name");
            string groupName = Console.ReadLine();
            if (groupName != null)
            {
                var parent = _context.ItemsGroups.Where(g => g.ItemsGroupName == groupName).FirstOrDefault();
                item.ItemsGroup = parent;
            }
            _context.Add(item);
            _context.SaveChanges();

        }

        public void Read(Guid? id)
        {
            var item = _context.Items.Where(i => i.ItemID == id).FirstOrDefault();
            Console.WriteLine("Items NomNr");
            Console.WriteLine(item.ItemNomNr);
            Console.WriteLine("Items Name");
            Console.WriteLine(item.ItemName);
            Console.WriteLine("Items Name EN");
            Console.WriteLine(item.ItemNameEN);
            Console.WriteLine("Items Name RU");
            Console.WriteLine(item.ItemNameRU);
            Console.WriteLine("Pricelist A price");
            Console.WriteLine(item.Pricelist_A);
            Console.WriteLine("Pricelist B price");
            Console.WriteLine(item.Pricelist_B);
            Console.WriteLine("Pricelist C price");
            Console.WriteLine(item.Pricelist_C);
            Console.WriteLine("Pricelist D price");
            Console.WriteLine(item.Pricelist_D);
            Console.WriteLine("Wharehouse qnt");
            Console.WriteLine(item.WharehouseQNT);
        }

        public void ReadByName(string name)
        {
            var item = _context.Items.Where(i => i.ItemName == name).FirstOrDefault();
            Console.WriteLine("Items NomNr");
            Console.WriteLine(item.ItemNomNr);
            Console.WriteLine("Items Name");
            Console.WriteLine(item.ItemName);
            Console.WriteLine("Items Name EN");
            Console.WriteLine(item.ItemNameEN);
            Console.WriteLine("Items Name RU");
            Console.WriteLine(item.ItemNameRU);
            Console.WriteLine("Pricelist A price");
            Console.WriteLine(item.Pricelist_A);
            Console.WriteLine("Pricelist B price");
            Console.WriteLine(item.Pricelist_B);
            Console.WriteLine("Pricelist C price");
            Console.WriteLine(item.Pricelist_C);
            Console.WriteLine("Pricelist D price");
            Console.WriteLine(item.Pricelist_D);
            Console.WriteLine("Wharehouse qnt");
            Console.WriteLine(item.WharehouseQNT);
        }

        static Dictionary<string, string> ItemsInput()
        {
            Console.WriteLine("Please write Items NomNr");
            string code = Console.ReadLine();
            Console.WriteLine("Please write Items Name");
            string name = Console.ReadLine();
            Console.WriteLine("Please write Items Name EN");
            string nameEN = Console.ReadLine();
            Console.WriteLine("Please write Items Name RU");
            string nameRU = Console.ReadLine();


            Dictionary<string, string> data = new Dictionary<string, string>()
            {
                {"code", code },
                { "name", name },
                { "nameEN", nameEN },
                { "nameRU", nameRU },
            };
            return data;
        }
    }
}
