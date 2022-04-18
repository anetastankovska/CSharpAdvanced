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
        public int ValidateInput(int min, int max)
        {
            int choice = int.MinValue;
            string input = Console.ReadLine();
            while (int.TryParse(input, out choice) && (choice < min || choice > max))
            {
                Console.WriteLine("Please enter a valid input.");
                input = Console.ReadLine();
            }
            return choice;
        }

        public bool ValidateUsernameAndPassword(string username, string password)
        {
            while (username.Length < 5)
            {
                Console.WriteLine("The username is too short. Please try again.");
                username = Console.ReadLine();
            }
            while (!password.Any(c => char.IsDigit(c)) && password.Length < 5)
            {
                Console.WriteLine("The password does not match the criteria. Please try again");
                password = Console.ReadLine();
            }
            return true;
        }

        public void ListAllUsers(List<User> users)
        {
            int counter = 1;
            foreach (User user in users)
            {
                Console.WriteLine($"{counter++}. {user}");
            }
        }
    }
}
