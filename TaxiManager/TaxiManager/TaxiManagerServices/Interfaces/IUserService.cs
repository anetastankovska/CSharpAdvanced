using Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IUserService
    {
        public User CurrentUser { get; set; }
        public List<User> Users { get; set; }

        public void Login();
        public User Logout();
        public void ChangePassword();
    }
}
