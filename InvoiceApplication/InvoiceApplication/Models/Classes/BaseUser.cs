using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes
{
    public abstract class BaseUser : IBaseUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

        private string _password;

        public BaseUser(string firstname, string lastname, string username, string password)
        {
            FirstName = firstname;
            LastName = lastname;
            Username = username;
            _password = password;
        }

        public bool CheckPassword(string password)
        {
            return _password == password;
        }
    }
}
