using Models.Classes;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUserService
    {
        public User CurrentUser { get; set; }
        public List<User> Users { get; set; } = new List<User>();

        public void Login()
        {
            throw new NotImplementedException();
        }

        public User Logout()
        {
            throw new NotImplementedException();
        }

        public void ChangePassword()
        {
            throw new NotImplementedException();
        }
    }
}
