using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Menus
    {
        Helpers helpers = new Helpers();
        public int MainMenu()
        {
            Console.WriteLine("***** Welcome to the TAXI MANAGER 9000 app ***** \nPlease select an option below: \n1. Login \n2. Exit");
            return helpers.ReturnValidChoice(1, 2);
        }
        public int AdminMenu()
        {
            Console.WriteLine("**** ADMINISTRATOR MENU **** \nPlease select an appropriate option below: \n1. Create new user \n2. Terminate user \n3. Change password \n4. Logout \n5. Exit");
            return helpers.ReturnValidChoice(1, 5);
        }
        public int MaintainanceMenu()
        {
            Console.WriteLine("**** MAINTAINANCE MENU **** \nPlease select an appropriate option below: \n1. List all vehicles \n2. License plate status \n3. Change password \n4. Logout \n5. Exit");
            return helpers.ReturnValidChoice(1, 5);
        }
        public int ManagerMenu()
        {
            Console.WriteLine("**** MANAGER MENU **** \nPlease select an appropriate option below: \n1. Assign drivers \n2. Unassign drivers \n3. Change password \n4. Logout \n5. Exit");
            return helpers.ReturnValidChoice(1, 5);
        }

        
    }
}
