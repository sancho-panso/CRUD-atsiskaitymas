using Crud.App.Data;
using Crud.App.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crud.App.Services
{
    public class ItemGroupService : IItemGroupService
    {
        private readonly Context _context;

        public ItemGroupService(Context context)
        {
            _context = context;
        }
        public void Create()
        {
            var data = ItemsGroupInput();
            ItemsGroup group = new ItemsGroup();
            group.ItemsGroupCode = data["code"];
            group.ItemsGroupName = data["name"];
            group.ItemsGroupNameEN = data["nameEN"];
            group.ItemsGroupNameRU = data["nameRU"];
            group.ParentItemsGroupID = null;
            Console.WriteLine("Please enter Parent Group Name, or none");
            string groupName = Console.ReadLine();
            if(groupName != "none")
            {
               var parent = _context.ItemsGroups.Where(g => g.ItemsGroupName == groupName).FirstOrDefault();
               group.ParentItemsGroup = parent;
            }
            _context.Add(group);
            _context.SaveChanges();


        }

        public void Delete(Guid? id)
        {
           var group = _context.ItemsGroups.Where(g => g.ItemsGroupID == id).FirstOrDefault();
            _context.Remove(group);
            _context.SaveChanges();
        }

        public void Edit(Guid? id)
        {
            var data = ItemsGroupInput();
            var group = _context.ItemsGroups.Where(g => g.ItemsGroupID == id).FirstOrDefault();
            group.ItemsGroupCode = data["code"];
            group.ItemsGroupName = data["name"];
            group.ItemsGroupNameEN = data["nameEN"];
            group.ItemsGroupNameRU = data["nameRU"];
            Console.WriteLine("Please enter Parent Group Name");
            string groupName = Console.ReadLine();
            if (groupName != null)
            {
                var parent = _context.ItemsGroups.Where(g => g.ItemsGroupName == groupName).FirstOrDefault();
                group.ParentItemsGroup = parent;
            }
            _context.Add(group);
            _context.SaveChanges();
        }

        public void Read(Guid? id)
        {
            var group = _context.ItemsGroups.Where(g => g.ItemsGroupID == id)
                                .Include(g=>g.ChildItemsGroups)
                                .Include(g=>g.Items).FirstOrDefault();
            Console.WriteLine("Items Group ID");
            Console.WriteLine(group.ItemsGroupID);
            Console.WriteLine("Items Group Code");
            Console.WriteLine(group.ItemsGroupCode);
            Console.WriteLine("Items Group Name");
            Console.WriteLine(group.ItemsGroupName);
            Console.WriteLine("Items Group Name EN");
            Console.WriteLine(group.ItemsGroupNameEN);
            Console.WriteLine("Items Group Name RU");
            Console.WriteLine(group.ItemsGroupNameRU);
            Console.WriteLine("Group items:");
            foreach (var item in group.Items)
            {
                Console.WriteLine(item.ItemName);
            } 
            Console.WriteLine("Child items groups:");
            foreach (var item in group.ChildItemsGroups)
            {
                Console.WriteLine(item.ItemsGroupName);
            }
        }

        public void ReadByName(string name)
        {
            var group = _context.ItemsGroups.Where(g => g.ItemsGroupName == name)
                    .Include(g => g.ChildItemsGroups)
                    .Include(g => g.Items).FirstOrDefault();
            Console.WriteLine("Items Group ID");
            Console.WriteLine(group.ItemsGroupID);
            Console.WriteLine("Items Group Code");
            Console.WriteLine(group.ItemsGroupCode);
            Console.WriteLine("Items Group Name");
            Console.WriteLine(group.ItemsGroupName);
            Console.WriteLine("Items Group Name EN");
            Console.WriteLine(group.ItemsGroupNameEN);
            Console.WriteLine("Items Group Name RU");
            Console.WriteLine(group.ItemsGroupNameRU);
            Console.WriteLine("Group items:");
            foreach (var item in group.Items)
            {
                Console.WriteLine(item.ItemName);
            }
            Console.WriteLine("Child items groups:");
            foreach (var item in group.ChildItemsGroups)
            {
                Console.WriteLine(item.ItemsGroupName);
            }
        }

        public static Dictionary<string, string> ItemsGroupInput()
        {
            Console.WriteLine("Please write Items Group Code");
            string code = Console.ReadLine();
            Console.WriteLine("Please write Items Group Name");
            string name = Console.ReadLine();
            Console.WriteLine("Please write Items Group Name EN");
            string nameEN = Console.ReadLine();  
            Console.WriteLine("Please write Items Group Name RU");
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
