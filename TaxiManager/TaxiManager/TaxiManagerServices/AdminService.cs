using Data;
using Models.Classes;
using Models.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AdminService : IAdminService
    {
        public List<IUser> Users { get; set; } = Repository.Users;

        public void CreateUser()
        {
            throw new NotImplementedException();
        }

        public string ListUsers()
        {
            throw new NotImplementedException();
        }

        public void TerminateUser()
        {
            throw new NotImplementedException();
        }
    }
}
