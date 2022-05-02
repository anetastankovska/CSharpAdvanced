using Data;
using Models.Classes;
using Models.Enums;
using Models.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Services
{
    public class ManagerService : IManagerService
    {
        public List<IDriver> Drivers { get; set; } = Repository.Drivers;
        public List<ICar> Cars { get; set; } = Repository.Cars;

        MaintainanceService MaintainanceService = new MaintainanceService();
        Helpers helpers = new Helpers();

        public List<IDriver> ListUnassignedDrivers()
        {
            List<IDriver> unassignedDrivers = Drivers.Where(x => x.Shift == Shift.None).ToList();
            return unassignedDrivers;
        }
        public string AssignDriver(List<IDriver> unassignedDrivers, int driverNum, Shift shift, ICar car)
        {
            unassignedDrivers[driverNum-1].Shift = shift;
            unassignedDrivers[driverNum-1].Car = car;
            return $"The driver {unassignedDrivers[driverNum - 1].FirstName} {unassignedDrivers[driverNum - 1].LastName} has been assigned to the car {car} on {shift} shift";
        }

        public List<ICar> ShowAvailableCars(Shift selectedShift)
        {
            List<ICar> availableCars = Cars.Where(x => x.IsCarAvailable(selectedShift)).ToList();
            return availableCars;
        }

        public List<IDriver> ListAssignedDrivers()
        {
            List<IDriver> assignedDrivers = Drivers.Where(x => x.Shift != Shift.None).ToList();
            return assignedDrivers;
        }

        public string UnassignDriver(List<IDriver> assignedDrivers, int driverNum)
        {
            assignedDrivers[driverNum - 1].Shift = Shift.None;
            return $"The driver {assignedDrivers[driverNum - 1].FirstName}, {assignedDrivers[driverNum - 1].LastName} has been unassigned";
        }
    }
}
