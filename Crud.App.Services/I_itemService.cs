using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.App.Services
{
    interface I_itemService
    {
        public void Create();
        public void Read(Guid? id);
        public void ReadByName(string name);
        public void Edit(Guid? id);
        public void Delete(Guid? id);
    }
}
