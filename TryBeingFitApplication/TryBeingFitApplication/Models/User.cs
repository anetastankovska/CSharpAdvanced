using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get;  init; }

        public User()
        {

        }
        public User(string firstname, string lastname, string username, string password)
        {
            FirstName = firstname;
            LastName = lastname;
            Username = username;
            Password = password;
        }
    }
}
