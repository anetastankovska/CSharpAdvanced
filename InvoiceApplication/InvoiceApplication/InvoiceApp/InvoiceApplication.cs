using Data;
using Models.Classes;
using Models.Interfaces;
using Services.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace InvoiceApp
{
    public class InvoiceApplication
    {
        IBaseUserService baseUserService = new BaseUserSrervice();

        IUserService userService = new UserService();

        IAdminService adminService = new AdminService();

        public void Start()
        {
            Repository.Init();
            while (true)
            {
                try
                {
                    int selection = 0;
                    if (baseUserService.CurrentUser == null)
                    {
                        selection = Menus.MainMenu();
                        if (selection == 1)
                        {
                            Console.Clear();
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter your username");
                                string username = Console.ReadLine();
                                Console.WriteLine("Please enter your password");
                                string password = Console.ReadLine();

                                if (baseUserService.Login(username, password) == null)
                                {
                                    Console.WriteLine("Login unsuccessful. Please try again");
                                    Console.ReadLine();
                                    continue;
                                }
                                break;
                            }
                        }
                        else
                        {
                            //throw new ApplicationException();
                            Console.WriteLine("Thank you for using our app.");
                            return;
                        }
                    }
                    Console.Clear();
                    //add the rest of the code here
                    if (baseUserService.CurrentUser.GetType() == typeof(User))
                    {
                        IUser currentUser = (IUser)baseUserService.CurrentUser;

                    }
                    else if (baseUserService.CurrentUser.GetType() == typeof(Admin))
                    {
                        AdminFlow();
                    }
                }
                catch (Exception ex)
                {
                    //Console.WriteLine("Thank you for using our app.");
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
        }

        public void AdminFlow()
        {
            IAdmin currentAdmin = (IAdmin)baseUserService.CurrentUser;
            Console.WriteLine($"The current invoices {currentAdmin.Company} has are: \n\n{adminService.ShowInvoices(currentAdmin.Company)} \n\nPress enter to log out");
            Console.ReadLine();
            Console.Write("Logging out");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.Clear();
            baseUserService.Logout();
        }

        public void UserFlow()
        {

        }
    }
}
