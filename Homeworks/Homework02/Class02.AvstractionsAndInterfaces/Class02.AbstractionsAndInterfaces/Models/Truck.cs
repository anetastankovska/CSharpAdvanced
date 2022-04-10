using Class02.AbstractionsAndInterfaces.Enums;
using Class02.AbstractionsAndInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.AbstractionsAndInterfaces.Models
{
    public class Truck : Vehicle
    {
        public Truck(string brand, string model, int registryNumber, Fuel fuel) : base(brand, model, registryNumber, fuel)
        {
        }

        public Truck(string brand, string model, int registryNumber, Fuel fuel, bool isClean, bool isBroken, bool isGasFull) : base(brand, model, registryNumber, fuel, isClean, isBroken, isGasFull)
        {
        }

        public override void Drive()
        {
            Console.WriteLine($"The truck {Model} with registry number {RegistryNumber} is driving.");
        }

        public override string ToString()
        {
            return $"Brand: {Brand}, model: {Model}, fuel: {Fuel}";
        }
    }
}
