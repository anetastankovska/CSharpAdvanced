using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class03.Polymorphism.Entities
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public abstract void Eat();

        public Pet(string name)
        {
            Name = name;
        }
    }
}
