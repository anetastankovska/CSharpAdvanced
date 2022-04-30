using Models.Classes;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    internal interface IAdminService
    {
        public List<IUser> Users { get; set; }

        public void CreateUser(List<string> credentials);

        public string ListUsers();

        public void TerminateUser(IUser user);
    }
}
