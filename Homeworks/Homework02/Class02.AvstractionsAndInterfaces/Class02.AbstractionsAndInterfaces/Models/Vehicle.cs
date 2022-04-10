using Class02.AbstractionsAndInterfaces.Enims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.AbstractionsAndInterfaces.Models
{
    public abstract class Vehicle
    {
        public string Model { get; set; }
        public int YearOfProduction { get; set; }
        public Fuel Fuel { get; set; }

        public Vehicle(string model, int yearOfProductions, Fuel fuel)
        {
            Model = model;
            YearOfProduction = yearOfProductions;
            Fuel = fuel;
        }

        public abstract void Drive();
        
    }
}
