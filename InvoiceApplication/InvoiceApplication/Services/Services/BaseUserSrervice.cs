using Data;
using Models.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class BaseUserSrervice : IBaseUserService
    {
        public IBaseUser CurrentUser { get; set; }

        public List<IBaseUser> GetAllUsers()
        {
            List<IBaseUser> allUsers = new List<IBaseUser>();
            allUsers.AddRange(Repository.Users);
            allUsers.AddRange(Repository.Admins);
            return allUsers;
        }

        public IBaseUser Login(string username, string password)
        {
            IBaseUser user = GetAllUsers().FirstOrDefault(x => x.Username == username && x.CheckPassword(password));
            CurrentUser = user;
            return CurrentUser;
        }

        public void Logout()
        {
            CurrentUser = null;
        }
    }
}
