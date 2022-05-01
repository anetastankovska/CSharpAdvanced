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

        MaintainanceService MaintainanceService = new MaintainanceService();

        public string ListDrivers()
        {
            List<string> strList = new List<string>();
            int cnt = 1;
            foreach (IDriver driver in Drivers)
            {
                
            }

        }
        public string TaxiLicenseStatus()
        {
            return MaintainanceService.ShowTaxiLicenseStatus();
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
