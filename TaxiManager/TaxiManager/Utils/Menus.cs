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
            Console.WriteLine("***** Welcome to the Taxi Manager 9000 app ***** \nPlease select an option below: \n1. Login \n2. Exit");
            int choice = helpers.ValidateInput(1, 2);
            return choice;
        }
        public int AdminMenu()
        {
            return 0;
        }
        public int ManagerMenu()
        {
            return 0;
        }
        public int MaintainaceMenu()
        {
            return 0;
        }
    }
}
