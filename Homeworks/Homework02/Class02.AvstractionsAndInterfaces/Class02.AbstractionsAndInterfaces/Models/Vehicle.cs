using Class02.AbstractionsAndInterfaces.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.AbstractionsAndInterfaces.Models
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int RegistryNumber { get; set; }
        public Fuel Fuel { get; set; }
        public bool IsClean { get; set; } = true;
        public bool IsBroken { get; set; } = false;
        public bool IsGasFull { get; set; } = false;

        public Vehicle(string brand, string model, int registryNumber, Fuel fuel)
        {
            Brand = brand;
            Model = model;
            RegistryNumber = registryNumber;
            Fuel = fuel;
         }

        public Vehicle(string brand, string model, int registryNumber, Fuel fuel, bool isClean, bool isBroken, bool isGasFull)
        {
            Brand = brand;
            Model = model;
            RegistryNumber = registryNumber;
            Fuel = fuel;
            IsClean = isClean;
            IsBroken = isBroken;
            IsGasFull = isGasFull;
        }

        public abstract void Drive();
        
    }
}
