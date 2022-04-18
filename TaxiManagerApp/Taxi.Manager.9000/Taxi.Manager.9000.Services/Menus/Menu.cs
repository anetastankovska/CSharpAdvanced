using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Manager._9000.Services.Helpers;
using Taxi.Manager._9000.Services.UserServices;

namespace Taxi.Manager._9000.Services.Menus
{
    public class Menu
    {
        Helper helpers = new Helper();
        UserService userService = new UserService()
        public int MainMenu()
        {
            Console.WriteLine("Welcome to the Taxi Manager 9000 app. \nPlease select your role below: \n1. Administrator \n2. Manager \n3. Maintainance");
            int choice = helpers.ValidateInput(1, 3);
            return choice;
        }
        public void MainAdminMenu()
        {
            Console.WriteLine("Please select an appropriate option below: \n1. Create new user \n2. Terminate user \n3. Change password \n4. Logout");
            int choice = helpers.ValidateInput(1, 4);
            switch (choice)
            {
                case 1:
                    userService.NewUser();
                    break;
                case 2:
                    userService.TerminateUser();
                    break;
                case 3:
                    userService.ChangePassword();
                    break;
                case 4:
                    userService.Logout();
                    break;
                default:
                    break;
            }
        }
    }
}
