using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Manager._9000.Models.Models;
using Taxi.Manager._9000.Services.Helpers;
using Taxi.Manager._9000.Services.MaintainanceServices;
using Taxi.Manager._9000.Services.ManagerServices;
using Taxi.Manager._9000.Services.Menus;
using Taxi.Manager._9000.Services.UserServices;

namespace Taxi.Manager._9000.App
{
    public class TaxiManagerApp
    {
        UserService UserService { get; set; } = new UserService();
        ManagerService ManagerService { get; set; } = new ManagerService();
        MaintainanceService MaintainanceService { get; set; } = new MaintainanceService();


        Menu menus = new Menu();

        
        public void Start()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    int choice = menus.MainMenu();
                    if (choice == 1)
                    {
                        User currentUser = UserService.Login();

                        
                        
                        
                        
                        
                        
                        Console.ReadLine();
                    }
                    else
                    {
                        UserService.Exit();
                    }
                   
                }
                catch (ApplicationException ex)
                {
                    break;
                }
            }
            
        }
    }
}
