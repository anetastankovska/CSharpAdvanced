using Models.Classes;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class UserService
    {
        public IUser CurrentUser { get; set; }

        public IUser Login(string username, string password)
        {
            return null;
        }

        public void Logout()
        {
            CurrentUser = null;
        }
    }
}
