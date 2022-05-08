using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class Menus
    {
        public static int MainMenu()
        {
            Console.WriteLine("*****Welcome to the invoice app***** \nPlease select an option below \n1. Login \n2. Exit");
            return Helpers.ValidadeInput(1, 2);
        }

        public static int UserMenu()
        {
            Console.WriteLine("Please select an option below. \n1. Check balance \n2. Cash deposit \n3. List invoices \n4. Pay invoice \n5. Logout");
            return Helpers.ValidadeInput(1, 5);
        }

        public static void AdminMenu()
        {
            Console.WriteLine("Welcome to your admin panel. Below you can see all the company invoices");
        }
    }
}
