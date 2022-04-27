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

        public int MainMenu()
        {
            Console.WriteLine("***** Welcome to the Taxi Manager 9000 app ***** \nPlease select an option below: \n1. Login \n2. Exit");
            int choice = helpers.ValidateInput(1, 2);
            return choice;
        }
        public int AdminMenu()
        {
            Console.WriteLine("Please select an appropriate option below: \n1. Create new user \n2. Terminate user \n3. Change password \n4. Logout \n5 Exit");
            int choice = helpers.ValidateInput(1, 5);
            return choice;
        }

        public int MaintainanceMenu()
        {
            Console.WriteLine("Please select an appropriate option below: \n1. List all vehicles \n2. License plate status \n3. Change password \n4. Logout \n 5. Exit");
            int choice = helpers.ValidateInput(1, 5);
            return choice;
        }

        public int ManagerMenu()
        {
            Console.WriteLine("Please select an appropriate option below: \n1. Assign drivers \n2. Unassign drivers \n3. Change password \n4. Logout \n. Exit");
            int choice = helpers.ValidateInput(1, 5);
            return choice;
        }

    }
}
