using Class02.AbstractionsAndInterfaces.Enims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.AbstractionsAndInterfaces.Models
{
    public class Car : Vehicle
    {
        public Car(string model, int yearOfProductions, Fuel fuel) : base(model, yearOfProductions, fuel)
        {
        }

        public override void Drive()
        {
            Console.WriteLine($"The vehicle {Model} is driving. ");
        }
    }
}
