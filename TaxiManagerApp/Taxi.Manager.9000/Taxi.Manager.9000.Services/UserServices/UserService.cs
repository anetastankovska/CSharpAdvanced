using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Manager._9000.Data;
using Taxi.Manager._9000.Models.Enums;
using Taxi.Manager._9000.Models.Models;
using Taxi.Manager._9000.Services.Helpers;
using Taxi.Manager._9000.Services.Interfaces;
using Taxi.Manager._9000.Services.Menus;

namespace Taxi.Manager._9000.Services.UserServices
{
    public class UserService : IUserService
    {
        User currentUser = null;

        Helper helpers = new Helper();
        Menu menus = new Menu();
        public User Login()
        {
            try
            {
                Console.WriteLine("Enter your username");
                string username = Console.ReadLine();
                User selected = Repository.Users.FirstOrDefault(x => x.UserName == username);
                if (selected == default)
                {
                    helpers.printColor("The user has not been found.", ConsoleColor.Red);
                    return null;
                }
                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();
                if (selected.Password != password)
                {
                    helpers.printColor("The password is incorrect.", ConsoleColor.Red);
                    return null;
                }
                currentUser = selected;
                helpers.printColor($"Succesful Login. Welcome {selected.Role}", ConsoleColor.Green);
                return selected;
            }
            catch (ArgumentNullException)
            {
                helpers.printColor("User not found. Please wait", ConsoleColor.Red);
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                return null;
            }
        }
        
        public void ChangePassword()
        {
            Console.WriteLine("Please enter your old password");
            string oldPassword = Console.ReadLine();
            while (currentUser.Password != oldPassword)
            {
                Console.WriteLine("The password does not match. Please try again");
                oldPassword = Console.ReadLine();
            }
            Console.WriteLine("Please enter the new password. The password must be at least 5 characters long and must contain at least one number.");
            string newPassword = Console.ReadLine();
            while (!newPassword.Any(c => char.IsDigit(c)) && newPassword.Length < 5)
            {
                Console.WriteLine("The password does not match the criteria. Please try again");
                newPassword = Console.ReadLine();
            }
            currentUser.Password = newPassword;
            Console.WriteLine("The password has been changed");
        }

        public void Logout()
        {
            currentUser = null;
        }

        public void Exit()
        {
            Console.WriteLine("Thank you for using our app");
            Thread.Sleep(3000);
            throw new AppExitException();
        }

    }
}
