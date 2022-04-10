using Class02.AbstractionsAndInterfaces.Interfaces;
using Class02.AbstractionsAndInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.AbstractionsAndInterfaces.Service
{
    public class RepairService : IRepairService
    {
        public bool CheckVehicle(Vehicle vehicle)
        {
            if (vehicle.IsBroken)
            {
                Console.WriteLine($"The {vehicle.Model} with registry number {vehicle.RegistryNumber} is broken and needs to be fixed.");
            }
            else
            {
                Console.WriteLine($"The {vehicle.Model} with registry number {vehicle.RegistryNumber} is in a very good condition");
            }
            return vehicle.IsBroken;
        }

        public void FixVehicle(Vehicle vehicle)
        {
            if (vehicle.IsBroken)
            {
                vehicle.IsBroken = false;
                Console.WriteLine($"The {vehicle.Model} with registry number {vehicle.RegistryNumber} has been fixed");
            }
            else
            {
                Console.WriteLine($"The {vehicle.Model} with registry number {vehicle.RegistryNumber} is in a very good condition and does not need any repairments.");
            }
        }
    }
}
