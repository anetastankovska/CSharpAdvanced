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

        public void TerminateUser()
        {
            ListAllUsers();
            Console.WriteLine("Please select the user you want to remove");
            int choice = helpers.ValidateInput(1, Repository.Users.Count);
            Repository.Users.Remove(Repository.Users[choice]);
            Console.WriteLine("The user has been terminated");
            menus.AdminMenu();
        }

        public void ListAllUsers()
        {
            int counter = 1;
            foreach (User user in Repository.Users)
            {
                Console.WriteLine($"{counter++}. {user}");
            }
        }

        public void Exit()
        {
            Console.WriteLine("Thank you for using our app");
            return;
        }

        public void Logout()
        {
            currentUser = null;
            menus.MainMenu();
        }

        public void NewUser()
        {
            while (true)
            {
                Console.WriteLine("Please enter a username (The username must be at least 5 characters long)");
                string username = Console.ReadLine();
                Console.WriteLine("Please enter a password (The password must be at least 5 characters long and contain at least one digit)");
                string password = Console.ReadLine();
                bool validUsernameAndPassword = helpers.ValidateUsernameAndPassword(username, password);
                if (!validUsernameAndPassword)
                {
                    Console.WriteLine("The credentials are not valid, try again");
                    break;
                }
                Console.WriteLine("Please select a role: \n1. Administrator \n2. Manager \n3. Maintainance ");
                int choice = helpers.ValidateInput(1, 3);
                User newUser = new User(Repository.Users.Count + 1, username, password, (Role)choice);
                Repository.Users.Add(newUser);
                break;
            }
            menus.AdminMenu();
        }

        public void BackTiMainMenu()
        {
            if(currentUser.Role == Role.Administrator)
            {
                menus.AdminMenu();
            }
        }
    }
}
