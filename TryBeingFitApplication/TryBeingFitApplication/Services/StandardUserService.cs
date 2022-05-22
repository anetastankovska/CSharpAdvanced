using Models;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces;
using Interfaces.Models;

namespace Services
{
    public class StandardUserService : IStandardUserService
    {
        public List<IStandardUser> StandardUsers { get; set; } = new List<IStandardUser>();
        public IStandardUser CurrentUser { get ; set ; }

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
                throw;
            }
        }

        public string GetAccount()
        {
            try
            {
                int len = CurrentUser.Password.Length;
                string account = $"FirstName: {CurrentUser.FirstName}\n lastname: {CurrentUser.LastName}\n {CurrentUser.Username}\n {CurrentUser.Password.Select(x => "*")}";
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

        public IPremiumUser UpgradeToPremium()
        {
            IPremiumUser newPremiumUser = new PremiumUser() { FirstName = CurrentUser.FirstName, LastName = CurrentUser.LastName, Username = CurrentUser.Username, Password = CurrentUser.Password, CompletedLiveTraining = false };
            StandardUsers.Remove(CurrentUser);
            return newPremiumUser;
        }
    }
}
