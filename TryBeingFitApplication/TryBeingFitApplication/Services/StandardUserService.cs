using Models;
using Interfaces;
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
            try
            {
                IStandardUser newUser = new StandardUser(firstname, lastname, username, password);
                StandardUsers.Add(newUser);
                return newUser;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something wrong happened");
                return null;
            }
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

        public IPremiumUser UpgradeToPremium(IStandardUser standardUser)
        {
            IPremiumUser newPremiumUser = new PremiumUser() { FirstName = standardUser.FirstName, LastName = standardUser.LastName, Username = standardUser.Username, Password = standardUser.Password};
            //add new premium user to the list with premium users
            //remove standard user from the list with standard users
            return newPremiumUser;
           
        }
    }
}
