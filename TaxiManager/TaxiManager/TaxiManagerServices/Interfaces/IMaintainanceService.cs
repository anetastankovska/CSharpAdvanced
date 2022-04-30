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
    public interface IMaintainanceService
    {
        public string ListAllCars();

        public Dictionary<Car, LicensePlateStatus> LicensePlatesStatus();

        public string ShowTaxiLicenseStatus();
    }
}
