using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override string ToString()
        {
            return $"{Id} {Model}, license plate: {LicensePlate}, license plate expiry date: {ExpiryDate}";
        }
    }
}
