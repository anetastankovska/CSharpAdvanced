using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Manager._9000.Models.Models;
using Taxi.Manager._9000.Services.Helpers;
using Taxi.Manager._9000.Models.Enums;
using Taxi.Manager._9000.Services.Menus;
using Taxi.Manager._9000.Services.Interfaces;

namespace Taxi.Manager._9000.Services.ManagerServices
{
    public class ManagerService : IManagerService
    {
        public List<Driver> Drivers { get; set; } = new List<Driver>();
        public List<Car> Cars { get; set; } = new List<Car>();

        Helper helpers = new Helper();
        Menu menus = new Menu();

        private List<Driver> ListUnassignedDrivers()
        {
            List<Driver> unassignedDrivers = Drivers.Where(x => x.Shift == Shift.None).ToList();
            int counter = 1;
            foreach (Driver driver in unassignedDrivers)
            {
                Console.WriteLine($"{counter++}. {driver}");
            }
            return unassignedDrivers;
        }

        public Driver AssignDriver()
        {
            int choice = 0;
            List<Driver> unassignedDrivers = ListUnassignedDrivers();
            if(unassignedDrivers.Count == 0)
            {
                helpers.RedirectToMenu(menus.AdminMenu, "There is no available driver at the moment. \nPress enter to continue");
            }
            choice = helpers.ValidateInput(1, unassignedDrivers.Count);
            unassignedDrivers[choice - 1].Shift = SelectShift();
            return unassignedDrivers[choice - 1];
        }

        private Shift SelectShift()
        {
            Console.WriteLine("Please select a shift: \n1. Morning \n2. Afternoon \n3. Evening");
            int choice = helpers.ValidateInput(1, 3);
            return (Shift)choice;
        }

        private List<Car> ListAvailableCars()
        {
            Shift selectedShift = SelectShift();
            List<Car> availableCars = Cars.Where(x => x.IsCarAvailable(selectedShift)).ToList();
            int counter = 1;
            foreach (Car car in availableCars)
            {
                Console.WriteLine($"{counter++}. {car}");
            }
            return availableCars;
        }

        public void selectAvailableCar()
        {
            int choice = 0;
            List<Car> availableCars = ListAvailableCars();
            if (availableCars.Count == 0)
            {
                helpers.RedirectToMenu(menus.AdminMenu, "There is no available car at the moment. \nPress enter to continue");
            }
            choice = helpers.ValidateInput(1, availableCars.Count);
            availableCars[choice - 1].AssignedDrivers.Add(AssignDriver());
        }

        private List<Driver> ListAssignedDrivers()
        {
            List<Driver> assignedDrivers = Drivers.Where(x => x.Shift != Shift.None).ToList();
            int counter = 1;
            foreach (Driver driver in assignedDrivers)
            {
                Console.WriteLine($"{counter++}. {driver}");
            }
            return assignedDrivers;
        }

        public void UnassignDrivers() 
        {
            int choice = 0;
            List<Driver> assignedDrivers = ListAssignedDrivers();
            if (assignedDrivers.Count == 0)
            {
                helpers.RedirectToMenu(menus.AdminMenu, "All the drivers are resting at the moment. \nPress enter to continue");
            }
            choice = helpers.ValidateInput(1, assignedDrivers.Count);
            assignedDrivers[choice - 1].Shift = SelectShift();
        }
    }
}
