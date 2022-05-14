using Models;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class StandardUserService
    {
        public List<IStandardUser> StandardUsers { get; set; }

        public IStandardUser Register(string firstname, string lastname, string username, string password)
        {
            IStandardUser newUser = new StandardUser(firstname, lastname, username, password);
            StandardUsers.Add(newUser);
            return newUser;
        }

        public string GetAccount(IStandardUser user)
        {
            try
            {
                int len = user.Password.Length;
                string account = $"FirstName: {user.FirstName}\n lastname: {user.LastName}\n {user.Username}\n {user.Password.Select(x => "*")}";
                return account;
            }
            catch (ArgumentNullException)
            {
                return "User does not exist";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
