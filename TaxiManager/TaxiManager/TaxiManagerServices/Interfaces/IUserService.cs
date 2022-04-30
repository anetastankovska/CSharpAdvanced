using Models.Classes;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IUserService
    {
        public IUser CurrentUser { get; set; }
        public List<IUser> Users { get; set; }

        public IUser Login(string username, string password);
        public void Logout();
        public void ChangePassword(string newPassword);
    }
}
