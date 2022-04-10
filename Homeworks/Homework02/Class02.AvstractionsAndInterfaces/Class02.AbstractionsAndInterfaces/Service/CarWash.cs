using Class02.AbstractionsAndInterfaces.Interfaces;
using Class02.AbstractionsAndInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.AbstractionsAndInterfaces.Service
{
    public class CarWash : IWashVehicle
    {
        
        public void WashCar(Car car)
        {
            if (!car.IsClean)
            {
                car.IsClean = true;
                Console.WriteLine("The car is washing...");
                Console.WriteLine($"The {car.Model} with registry number {car.RegistryNumber} is now clean.");
            }
            else
            {
                Console.WriteLine($"The car {car.Model} with registry number {car.RegistryNumber} is already clean.");
            }
        }

        public void WashTruck(Truck truck)
        {
            if (!truck.IsClean)
            {
                truck.IsClean = true;
                Console.WriteLine("The truck is washing...");
                Console.WriteLine($"The {truck.Model} with registry number {truck.RegistryNumber} is now clean.");
            }
            else
            {
                Console.WriteLine($"The {truck.Model} with registry number {truck.RegistryNumber} is already clean.");
            }
        }

    }
}
