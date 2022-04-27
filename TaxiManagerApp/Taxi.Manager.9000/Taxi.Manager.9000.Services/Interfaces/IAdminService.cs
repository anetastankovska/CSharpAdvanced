using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Manager._9000.Services.Interfaces
{
    public interface IAdminService
    {
        public void ListAllUsers();
        public void TerminateUser();
        public void NewUser();
    }
}
