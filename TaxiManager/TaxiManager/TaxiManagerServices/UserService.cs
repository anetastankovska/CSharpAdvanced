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
    public class UserService : IUserService
    {
        public IUser CurrentUser { get; set; }
        public List<IUser> Users { get; set; } = Repository.Users;

        public IUser Login(string username, string password)
        {
            IUser selected = Users.FirstOrDefault(x => x.Username == username);
            if(selected == default)
            {
                return null;
            }
            else
            {
                if(selected.GetPassword() != password)
                {
                    return null;
                }
            }
            CurrentUser = selected;
            return CurrentUser;
        }

        public void Logout()
        {
            CurrentUser = null;
        }

        public void ChangePassword(string newPassword)
        {
            CurrentUser.SetPassword(newPassword);
        }

    }
}
