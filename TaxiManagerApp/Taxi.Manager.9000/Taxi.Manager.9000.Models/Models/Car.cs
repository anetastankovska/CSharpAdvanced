using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Manager._9000.Models.Enums;

namespace Taxi.Manager._9000.Models.Models
{
    public class Car : BaseEntity
    {
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public List<Driver> AssignedDrivers { get; set; } = new List<Driver>();

        public Car() { }

        public Car(int id, string model, string licensePlate, DateTime expiryDate)
            : base(id)
        {
            Model = model;
            LicensePlate = licensePlate;
            ExpiryDate = expiryDate;
        }

        public Car(int id, string model, string licensePlate, DateTime expiryDate, List<Driver> assignedDrivers)
            : base(id)
        {
            Model = model;
            LicensePlate = licensePlate;
            ExpiryDate = expiryDate;
            AssignedDrivers = assignedDrivers;
        }

        public override string ToString()
        {
            return $"{Id} {Model}, license plate: {LicensePlate}, license plate expiry date: {ExpiryDate}";
        }

        public bool IsCarAvailable(Shift shift)
        {
            int compare = DateTime.Compare(ExpiryDate, DateTime.Now.Date);
            if (compare < 1)
            {
                return false;
            }
            else
            {
                //return AssignedDrivers.All(x => x.Shift != shift);
                return !AssignedDrivers.Select(x => x.Shift).Contains(shift);
                //foreach (Driver driver in AssignedDrivers)
                //{
                //    if (driver.Shift == shift)
                //    {
                //        return false;
                //    }
                //}
                //return true;
            }

        }

        public void PrintLicenseStatus()
        {

        }
    }
}
