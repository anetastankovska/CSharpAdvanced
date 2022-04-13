using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Manager._9000.Models.Enums;

namespace Taxi.Manager._9000.Models.Models
{
    public class Driver : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Shift Shift { get; set; }
        public Car Car { get; set; }
        public string License { get; set; }
        DateTime LicenseExpiryDate { get; set; }

        public Driver() { }

        public Driver(int id, string firstName, string lastName, Shift shift, Car car, string license, DateTime licenseExpiryDate)
            : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Shift = shift;
            Car = car;
            License = license;
            LicenseExpiryDate = licenseExpiryDate;
        }

    }
}
