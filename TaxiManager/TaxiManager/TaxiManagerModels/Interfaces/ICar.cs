using Models.Classes;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface ICar
    {
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public List<IDriver> AssignedDrivers { get; set; }

        public double CheckUtilized();
        public bool IsCarAvailable(Shift shift);
        public LicensePlateStatus CarLicenseStatus();
    }
}
