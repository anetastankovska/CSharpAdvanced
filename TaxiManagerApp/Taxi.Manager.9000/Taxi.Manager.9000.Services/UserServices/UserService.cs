using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Manager._9000.Data;
using Taxi.Manager._9000.Models.Models;
using Taxi.Manager._9000.Services.Helpers;
using Taxi.Manager._9000.Services.Interfaces;
using Taxi.Manager._9000.Services.Menus;

namespace Taxi.Manager._9000.Services.UserServices
{
    public class UserService : IUserService
    {
        public User Login()
        {
            User user;
            while (true)
            {
                Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                user = SearchForUsernameAndPassword(username, password);
                if (user == null)
                {
                    Console.WriteLine("Login unsuccessful. Please try again.");
                    break;

                }
                Console.WriteLine($"Successful Login! Welcome {user.Role} user!");
                break;
            }
            return user;            
        }

        public void ChangePassword()
        {

        }

        //public User CreateUser()
        //{
        //    Console.WriteLine("Username:");
        //    string username = Console.ReadLine();
        //    Console.WriteLine("Password:");
        //    string password = Console.ReadLine();
        //}

        public void TerminateUser()
        {

        }

        public void Exit()
        {
            return;
        }


        public User SearchForUsernameAndPassword(string username, string password)
        {
            User user = Repository.Users.FirstOrDefault(x => x.UserName == username);   
            if (user.UserName == username)
            {
                return user;
            }
            return null;
        }

        public User CreateUser()
        {
            throw new NotImplementedException();
        }

        //public User ValidateUsernameAndPassword(string username, string password)
        //{
        //    while(username.Length < 5)
        //    {
        //        Console.WriteLine("The username is too short. Try another one");
        //        username = Console.ReadLine();
        //    }
        //    string[] passArray = password.Split("");
        //    foreach (string x in passArray)
        //    {
        //        if(!int.TryParse(x, out int value))
        //        {
        //            Console.WriteLine("The password is not valid. Please try again.");
        //        }

        //    }


    
    }
}
