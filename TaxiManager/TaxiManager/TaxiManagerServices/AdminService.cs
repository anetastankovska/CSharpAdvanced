using Data;
using Models.Classes;
using Models.Enums;
using Models.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AdminService : IAdminService
    {
        public List<IUser> Users { get; set; } = Repository.Users;

        public void CreateUser(List<string> credentials)
        {
            Role role = (Role)int.Parse(credentials[2]);
            IUser newUser = new User(Users.Count, credentials[0], credentials[1], role);
            Users.Add(newUser);
        }

        public void CreateUser(string username, string password, int role)
        {
            Role r = (Role)role;
            IUser newUser = new User(Users.Count, username, password, r);
            Users.Add(newUser);
        }

        public string ListUsers()
        {
            return string.Join("\n", Users.Select(x => $"{Users.IndexOf(x)+1}. {x}"));
        }

        public void TerminateUser(IUser user)
        {
            Users.Remove(user);
        }
    }
}
