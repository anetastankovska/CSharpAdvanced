using Models.Enums;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes
{
    public class Car : BaseEntity, ICar
    {
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public List<IDriver> AssignedDrivers { get; set; } = new List<IDriver>();

        public Car() { }
        public Car(int id, string model, string licensePlate, DateTime expiryDate)
            : base(id)
        {
            Model = model;
            LicensePlate = licensePlate;
            ExpiryDate = expiryDate;
        }
        public Car(int id, string model, string licensePlate, DateTime expiryDate, List<IDriver> assignedDrivers)
            : base(id)
        {
            Model = model;
            LicensePlate = licensePlate;
            ExpiryDate = expiryDate;
            AssignedDrivers = assignedDrivers;
        }

        public bool IsCarAvailable(Shift shift)
        {
            throw new NotImplementedException();
        }

        public LicensePlateStatus CarLicenseStatus()
        {
            throw new NotImplementedException();
        }
    }
}
