using Models.Enums;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes
{
    public class User : BaseEntity, IUser
    {
        public string Username { get; set; }

        private string _password;
        public Role Role { get; set; }

        public User() { }

        public User(int id, string username, string password, Role role)
            : base(id)
        {
            Username = username;
            _password = password;
            Role = role;
        }

        public string GetPassword()
        {
            return _password;
        }

        public void SetPassword(string password)
        {
            _password = password;
        }

        public override string ToString()
        {
            return $"{Id} - {Username} {Role}";
        }
    }
}
