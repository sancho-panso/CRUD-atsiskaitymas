using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.App.Services
{
    interface IOrderService
    {
        public void Read(string inumberd);
        public void Create();
        public void Edit(Guid client_ID);
        public void Delete(Guid? id);
    }
}
