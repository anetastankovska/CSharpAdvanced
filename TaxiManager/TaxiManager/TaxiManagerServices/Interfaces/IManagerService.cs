using Models.Classes;
using Models.Enums;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IManagerService
    {
        public List<IDriver> Drivers { get; set; }
        public List<ICar> Cars { get; set; }
        public List<IDriver> ListUnassignedDrivers();
        public string AssignDriver(List<IDriver> unassignedDrivers, int driverNum, Shift shift, ICar car);
        public List<ICar> ShowAvailableCars(Shift selectedShift);
        public List<IDriver> ListAssignedDrivers();
        public string UnassignDriver(List<IDriver> assignedDrivers, int driverNum);

    }
}
