using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Manager._9000.Models.Models;

namespace Taxi.Manager._9000.Services.Interfaces
{
    public interface IManagerService
    {
        public List<Driver> Drivers { get; set; }
        public List<Car> Cars { get; set; }

        public Driver AssignDriver();
        public void selectAvailableCar();
        public void UnassignDrivers();
    }
}
