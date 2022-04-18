using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Manager._9000.Models.Models
{
    public class Car : BaseEntity
    {
        string Model { get; set; }
        string LicensePlate { get; set; }
        DateTime ExpiryDate { get; set; }
        List<Driver> AssignedDrivers { get; set; } = new List<Driver>();

        public Car() { }

        public Car(int id, string model, string licensePlate, DateTime expiryDate)
            : base(id)
        {
            Model = model;
            LicensePlate = licensePlate;
            ExpiryDate = expiryDate;
        }

        public override string ToString()
        {
            return $"{Id} {Model}, license plate: {LicensePlate}, license plate expiry date: {ExpiryDate}";
        }
    }
}
