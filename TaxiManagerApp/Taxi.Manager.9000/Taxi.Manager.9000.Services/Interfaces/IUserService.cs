using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Manager._9000.Models.Models;

namespace Taxi.Manager._9000.Services.Interfaces
{
    public interface IUserService
    {
        public User Login();
        public void ChangePassword();
        public User NewUser();
        public void TerminateUser();
        public void Exit();
    }
}
