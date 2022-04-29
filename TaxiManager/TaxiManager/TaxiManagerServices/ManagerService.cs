using Data;
using Models.Classes;
using Models.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ManagerService : IManagerService
    {
        public List<IDriver> Drivers { get; set; } = Repository.Drivers;
        public List<ICar> Cars { get; set; } = Repository.Cars;

        public List<IDriver> ListDrivers()
        {
            throw new NotImplementedException();
        }
        public string TaxiLicenseStatus()
        {
            throw new NotImplementedException();
        }
        public IDriver AssignDriver()
        {
            throw new NotImplementedException();
        }
        public IDriver UnassignDriver()
        {
            throw new NotImplementedException();
        }

    }
}
