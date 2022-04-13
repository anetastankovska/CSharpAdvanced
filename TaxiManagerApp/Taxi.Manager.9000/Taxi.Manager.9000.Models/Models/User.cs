using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Manager._9000.Models.Enums;

namespace Taxi.Manager._9000.Models.Models
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User() { }

        public User(int id, string username, string password, Role role)
            : base(id)
        {
            UserName = username;
            Password = password;
            Role = role;
        }

       
    }
}
