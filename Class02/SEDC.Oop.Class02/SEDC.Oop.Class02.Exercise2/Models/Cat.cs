using SEDC.Oop.Class02.Exercise2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class02.Exercise2.Models
{
    public class Cat : Animal, ICat
    {
        public Cat(string name, int age, string color)
            : base(name, age, color)
        {

        }

        //public void PrintAnimal()
        //{
        //    Console.WriteLine($"The cat {Name} is {Age} years old and its color is {Color}.");
        //}

        public void Eat(string food)
        {
            Console.WriteLine($"The cat {Name} eats {food}.");
        }
    }
}
