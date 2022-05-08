using Data;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IBaseUserService
    {
        public IBaseUser CurrentUser { get; set; }

        public List<IBaseUser> GetAllUsers();
        public IBaseUser Login(string username, string password);
        public void Logout();
    }
}
