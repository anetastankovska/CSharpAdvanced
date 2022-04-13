using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Manager._9000.Data;
using Taxi.Manager._9000.Models.Models;

namespace Taxi.Manager._9000.Services.Helpers
{
    public class Helper
    {
        public User ValidateUsernameAndPassword(string username, string password)
        {
            User user = Repository.Users.FirstOrDefault(x => x.UserName == username);
            while(user == null)
            {
                Console.WriteLine("The user with such username does not exists");
                username = Console.ReadLine();
            }
            while(user.Password != password)
            {
                Console.WriteLine("The password is incorrect. Please try again");
                password = Console.ReadLine();
            }
            return user;
        }
    }
}
