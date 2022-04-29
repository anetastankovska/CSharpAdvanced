using Models.Enums;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes
{
    public class Driver : BaseEntity, IDriver
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Shift Shift { get; set; }
        public ICar Car { get; set; }
        public string License { get; set; }
        DateTime LicenseExpiryDate { get; set; }
       
        DateTime IDriver.LicenseExpiryDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName}. Shift: {Shift}, car: {Car}, license: {License}, license expiry date: {LicenseExpiryDate}";
        }

    }
}

