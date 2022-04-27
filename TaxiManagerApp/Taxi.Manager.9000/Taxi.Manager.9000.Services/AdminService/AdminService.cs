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

namespace Taxi.Manager._9000.Services.AdminService
{
    public class AdminService : IAdminService
    {
        Helper helpers = new Helper();
        Menu menus = new Menu();
        public void ListAllUsers()
        {
            int counter = 1;
            foreach (User user in Repository.Users)
            {
                Console.WriteLine($"{counter++}. {user}");
            }
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

    }
}
