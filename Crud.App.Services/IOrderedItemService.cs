using Crud.App.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.App.Services
{
    interface IOrderedItemService
    {
        public void Read(Guid? id);
        public void Create(string order);
        public void Edit(Guid id);
        public void Delete(Guid? id);
    }
}
