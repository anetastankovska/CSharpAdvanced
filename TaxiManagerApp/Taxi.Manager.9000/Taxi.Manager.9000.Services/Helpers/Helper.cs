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
                printColor("Please enter a valid input.", ConsoleColor.Red);
                input = Console.ReadLine();
            }
            return choice;
        }

        public bool ValidateUsernameAndPassword(string username, string password)
        {
            while (username.Length < 5)
            {
                printColor("The username is too short. Please try again.", ConsoleColor.Red);
                username = Console.ReadLine();
            }
            while (!password.Any(c => char.IsDigit(c)) && password.Length < 5)
            {
                printColor("The password does not match the criteria. Please try again", ConsoleColor.Red);
                password = Console.ReadLine();
            }
            return true;
        }

        public double CheckUtilized(List<Car> cars, string UtilizedCar)
        {
            int counter = 0; 
            foreach (Car car in cars)
            {
                if(car.Model == UtilizedCar)
                {
                    counter++;
                }
            }
            return counter / cars.Count * 100;
        }

        public Action<string, ConsoleColor> printColor = (text, color) =>
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        };

        public void RedirectToMenu(Func<int> menu, string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
            Console.Clear();
            menu.Invoke();
        }
    }
}
