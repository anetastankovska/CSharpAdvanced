using Models.Classes;
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
        public List<IDriver> ListDrivers();
        public string TaxiLicenseStatus();
        public IDriver AssignDriver();
        public IDriver UnassignDriver();

    }
}
