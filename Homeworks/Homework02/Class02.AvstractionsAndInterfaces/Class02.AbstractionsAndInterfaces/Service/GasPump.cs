using Class02.AbstractionsAndInterfaces.Interfaces;
using Class02.AbstractionsAndInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.AbstractionsAndInterfaces.Service
{
    public class GasPump : IGasPump
    {
        public void RefillGas(Vehicle vehicle)
        {
            if (vehicle.IsGasFull)
            {
                vehicle.IsGasFull = true;
                Console.WriteLine($"The tank of the {vehicle.Model} with registry number {vehicle.RegistryNumber} is now full.");
            }
            else
            {
                Console.WriteLine($"The tank of the {vehicle.Model} with registry number {vehicle.RegistryNumber} is already full.");
            }
        }
    }
}
