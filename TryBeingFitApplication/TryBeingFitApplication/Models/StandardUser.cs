using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StandardUser : User, IStandardUser
    {
        public StandardUser()
        {
            
        }
        public StandardUser(string firstname, string lastname, string username, string password)
            : base(firstname, lastname, username, password)
        {
         
        }
    }
}
