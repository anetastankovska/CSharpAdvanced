using Models.Enums;
using Models.Interfaces;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace TaxiManagerApp
{
    public class TaxiManagerApplication
    {
        UserService UserService { get; set; } = new UserService();
        AdminService AdminService { get; set; } = new AdminService();
        ManagerService ManagerService { get; set; } = new ManagerService();
        MaintainanceService MaintainanceService { get; set; } = new MaintainanceService();

        Menus menus = new Menus();

        Helpers helpers = new Helpers();

        public void Start()
        {
            while (true)
            {
                try
                {
                    int selection = 0;
                    if (UserService.CurrentUser == null)
                    {
                        selection = menus.MainMenu();
                        if (selection == 1)
                        {
                            Console.Clear();
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a username");
                                string username = Console.ReadLine();
                                Console.WriteLine("Please enter a password");
                                string password = Console.ReadLine();
                                if (UserService.Login(username, password) == null)
                                {
                                    helpers.printWithColor("Login unsuccessful. Please try again", ConsoleColor.Red);
                                    Console.ReadLine();
                                    continue;
                                }
                                break;
                            }
                        }
                        
                    }
                    else if (selection == 2)
                    {
                        throw new ApplicationException();
                    }
                    Role role = UserService.CurrentUser.Role;

                    Console.Clear();
                    helpers.printWithColor($"Welcome {role} user!", ConsoleColor.Green);

                    switch (role)
                    {
                        case Role.Administrator:
                            AdminFlow();
                            break;
                        case Role.Manager:
                            ManagerFlow();
                            break;
                        case Role.Maintainance:
                            MaintainanceFlow();
                            break;
                        default:
                            break;
                    }

                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine("Thank you for using our app");
                    return;
                }
                catch (OperationCanceledException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void AdminFlow()
        {
            int selectedOption = menus.AdminMenu();
            switch (selectedOption)
            {
                case 1:
                    List<string> credentials = helpers.CreateNewUser();
                    AdminService.CreateUser(credentials[0], credentials[1], int.Parse(credentials[2]));
                    Console.WriteLine($"User {UserService.Users.Last()} successfully added");
                    Console.WriteLine("All users:");
                    Console.WriteLine(string.Join("\n", UserService.Users));
                    Console.ReadLine();
                    break;
                case 2:
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"Select a user from the list below: \n{AdminService.ListUsers()}");
                        Console.WriteLine($"\n\n{UserService.Users.Count + 1}. Back to main menu.");
                        int choice1 = helpers.ReturnValidChoice(1, UserService.Users.Count + 1);
                        if (choice1 == UserService.Users.Count + 1)
                        {
                            throw new OperationCanceledException("Back to main Admin menu");
                        }
                        IUser selectedUser = UserService.Users[choice1 - 1];
                        if(selectedUser == UserService.CurrentUser)
                        {
                            Console.WriteLine("You cannot remove yourself. Press enter to select another user");
                            Console.ReadLine();
                            continue;
                        }
                        AdminService.TerminateUser(selectedUser);
                        Console.WriteLine($"The user {selectedUser} has been removed.");
                        Console.ReadLine();
                        break;
                    }
                    break;
                case 3:
                    Console.Clear();
                    string newPass = helpers.RequestPassChange(UserService.CurrentUser.GetPassword());
                    UserService.ChangePassword(newPass);
                    Console.WriteLine("The password has been successfully changed");
                    Console.ReadLine();
                    break;
                case 4:
                    UserService.Logout();
                    helpers.LogoutMock();
                    Console.Clear();
                    break;
                case 5:
                    throw new ApplicationException();
                default:
                    break;
            }
        }

        public void MaintainanceFlow()
        {
            int selectedOption = menus.MaintainanceMenu();
            switch (selectedOption)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine($"List of all vehicles \n{MaintainanceService.ListAllCars()}");
                    Console.WriteLine("\n\n [Enter] Back to main menu");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(MaintainanceService.ShowTaxiLicenseStatus());
                    Console.WriteLine("\n\n [Enter] Back to main menu");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    string newPass = helpers.RequestPassChange(UserService.CurrentUser.GetPassword());
                    UserService.ChangePassword(newPass);
                    Console.WriteLine("The password has been successfully changed");
                    Console.ReadLine();
                    break;
                case 4:
                    UserService.Logout();
                    helpers.LogoutMock();
                    Console.Clear();
                    break;
                case 5:
                    throw new ApplicationException();
                default:
                    break;
            }
        }

        public void ManagerFlow()
        {
            int selectedOption = menus.ManagerMenu();
            switch (selectedOption)
            {
                case 1:
                    Console.Clear();
                    List<IDriver> unassignedDrivers = ManagerService.ListUnassignedDrivers();
                    if (unassignedDrivers == null)
                    {
                        Console.WriteLine("All the drivers are on charge at the moment.");
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Please select a driver to assign it: \n");
                    Console.WriteLine(string.Join("\n", unassignedDrivers.Select(x => $"{unassignedDrivers.IndexOf(x) + 1}. {x}")));
                    Console.WriteLine($"\n\n{unassignedDrivers.Count + 1}. Back to main menu.");
                    int selectedDriverToAssign = helpers.ReturnValidChoice(1, unassignedDrivers.Count + 1);
                    if (selectedDriverToAssign == unassignedDrivers.Count + 1)
                    {
                        throw new OperationCanceledException("Back to main Manager menu");
                    }
                    Console.Clear();
                    Console.WriteLine("Please select a shift: \n1. Morning \n2. Afternoon \n3. Evening \n4. Back to main menu");
                    int choice = helpers.ReturnValidChoice(1, 4);
                    if (choice == 4)
                    {
                        throw new OperationCanceledException("Back to main Manager menu");
                    }
                    Shift selectedShift = (Shift)choice;
                    Console.Clear();
                    Console.WriteLine("Please select a car");
                    List<ICar> availableCars = ManagerService.ShowAvailableCars(selectedShift);
                    Console.WriteLine(string.Join("\n", availableCars.Select(x => $"{availableCars.IndexOf(x)+1}. {x}")));
                    Console.WriteLine($"{availableCars.Count +1}. Back to main menu");
                    int choice1 = helpers.ReturnValidChoice(1, availableCars.Count + 1);
                    if (choice1 == availableCars.Count + 1)
                    {
                        throw new OperationCanceledException("Back to main Manager menu");
                    }
                    ICar car = availableCars[choice1-1];
                    Console.WriteLine(ManagerService.AssignDriver(unassignedDrivers, selectedDriverToAssign, selectedShift, car));
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    List<IDriver> assignedDrivers = ManagerService.ListAssignedDrivers();
                    if (assignedDrivers == null)
                    {
                        Console.WriteLine("All the drivers are resting at the moment.");
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Please select a driver to unassign it: \n");
                    Console.WriteLine(string.Join("\n", assignedDrivers.Select(x => $"{assignedDrivers.IndexOf(x) + 1}. {x}")));
                    Console.WriteLine($"\n\n{assignedDrivers.Count + 1}. Back to main menu.");
                    int selectedDriverToUnassign = helpers.ReturnValidChoice(1, assignedDrivers.Count + 1);
                    if (selectedDriverToUnassign == assignedDrivers.Count + 1)
                    {
                        throw new OperationCanceledException("Back to main Manager menu");
                    }
                    Console.WriteLine(ManagerService.UnassignDriver(assignedDrivers, selectedDriverToUnassign));
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    string newPass = helpers.RequestPassChange(UserService.CurrentUser.GetPassword());
                    UserService.ChangePassword(newPass);
                    Console.WriteLine("The password has been successfully changed");
                    Console.ReadLine();
                    break;
                case 4:
                    UserService.Logout();
                    helpers.LogoutMock();
                    Console.Clear();
                    break;
                case 5:
                    throw new ApplicationException();
                default:
                    break;
            }
        }
    }
}
