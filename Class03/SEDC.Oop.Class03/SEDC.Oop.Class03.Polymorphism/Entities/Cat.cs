using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class03.Polymorphism.Entities
{
    public class Cat : Pet
    {
        public int NumberOfBalls { get; set; }

        public Cat(string name, int numberOfBalls)
            : base(name)
        {
            NumberOfBalls = numberOfBalls;
        }

        public override void Eat()
        {
            Console.WriteLine("The cat is eating");
        }
    }
}
