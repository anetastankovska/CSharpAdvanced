using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class04.Exercise1.Entities
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public bool LivesLeft { get; set; }

        public Cat(string name, string type, int age)
            :base(name, type, age)
        {
            Lazy = true;
            LivesLeft = true;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"The name of the cat is {Name}");
        }
    }
}
