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
                        UserFlow();
                    }
                    else if (baseUserService.CurrentUser.GetType() == typeof(Admin))
                    {
                        AdminFlow();
                    }
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine(ex.Message);
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
            adminService.CurrentAdmin = (IAdmin)baseUserService.CurrentUser;
            Console.WriteLine($"The current invoices {adminService.CurrentAdmin.Company} has are: \n\n{adminService.ShowInvoices(adminService.CurrentAdmin.Company)} \n\nPress enter to log out");
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
            userService.CurrentUser = (IUser)baseUserService.CurrentUser;
            int selection = Menus.UserMenu();
            switch (selection)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine($"Your current balance is {userService.CheckBalance()} MKD");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    int amount = Helpers.CheckDeposit();
                    userService.CashDeposit(amount);
                    Console.WriteLine($"Your current balance is {userService.CurrentUser.CurrentBalance}");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine($"Your current invoices: \n\n{userService.ShowAllInvoices()}");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine($"Please select the invoice you want to pay: \n\n{userService.ShowUnpaidInvoices()}");
                    int selectedInvoice = Helpers.ValidadeInput(1, userService.GetUnpaidInvoices().Count);
                    IInvoice invoiceToPay = userService.PickInvoice(selectedInvoice);
                    userService.PayInvoice(invoiceToPay);
                    Console.WriteLine($"The invoice {invoiceToPay} has been paid");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.Write("Logging out");
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(500);
                    }
                    Console.Clear();
                    baseUserService.Logout();
                    break;
                default:
                    break;
            }
        }
    }
}
