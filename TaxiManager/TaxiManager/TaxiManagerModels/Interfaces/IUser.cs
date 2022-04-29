using Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IUser
    {
        public string Username { get; set; }

        public string GetPassword();
        public void SetPassword(string password);


    }
}
