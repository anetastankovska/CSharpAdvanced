using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.QuizApp.Models
{
    public class User
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        private string password;

        public User() { }

        public User(string name, string username, string pass)
        {
            Name = name;
            UserName = username;
            password = pass;
        }

        public bool CheckPassword(string userPass)
        {
            return password.Equals(userPass);
        }
    }
}
