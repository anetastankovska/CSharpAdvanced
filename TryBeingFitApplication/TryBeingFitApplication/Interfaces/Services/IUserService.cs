using Interfaces;
using Interfaces.Models;
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
        public IUser Login<T>(string username, string password);
        public void Logout();
        public void Exit();
    }
}
