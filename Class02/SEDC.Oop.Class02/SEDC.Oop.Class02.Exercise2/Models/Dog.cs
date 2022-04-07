using SEDC.Oop.Class02.Exercise2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class02.Exercise2.Models
{
    public class Dog : Animal, IDog
    {
        public Dog(string name, int age, string color)
            :base(name, age, color)
        {

        }

        public void PrintAnimal()
        {
            base.PrintAnimal();
            Console.WriteLine($"The dog's name is {Name}. It is {Age} years old and its color is {Color}");
        }

        public void Bark()
        {
            Console.WriteLine($"The dog {Name} is barking.");
        }

    }
}
