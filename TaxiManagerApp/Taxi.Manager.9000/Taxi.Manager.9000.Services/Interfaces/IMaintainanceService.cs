using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Manager._9000.Models.Enums;
using Taxi.Manager._9000.Models.Models;

namespace Taxi.Manager._9000.Services.Interfaces
{
    public interface IMaintainanceService
    {
        List<Car> Cars { get; set; }
        public string ListAllVehicles();
        public Dictionary<Car, LicensePlateStatus> LicensePlatesStatus();
        public string ShowTaxiLicenseStatus();

    }
}
