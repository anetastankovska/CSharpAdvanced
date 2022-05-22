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
        public IUser Login<T>(string username, string password);
        public void Train<T>();
        public void Exit<T>();
    }
}
