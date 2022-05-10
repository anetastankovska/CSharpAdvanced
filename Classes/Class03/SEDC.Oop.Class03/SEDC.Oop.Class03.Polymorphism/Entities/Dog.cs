using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class03.Polymorphism.Entities
{
    public class Dog : Pet
    {
        public string Breed { get; set; }
        public int Number { get; set; }

        public Dog() : base("sharko") 
        {
        }

        public Dog(string name)
            : base(name)
        {

        }

        public Dog(int num)
            : base("bleki")
        {
            Number = num;
        }
        // CANNOT DO THIS because the parameter is string and we already have string (breed). It would be possible if the parameter is from other type
        //public Dog(string breed)
        //    : base("Bleki")
        //{
        //    Breed = breed;
        //}

        public Dog(string name, string breed)
            : base(name)
        {
            Breed = breed;
        }
        public override void Eat()
        {
            Console.WriteLine($"The dog {Breed} is eating");
        }

    }
}
