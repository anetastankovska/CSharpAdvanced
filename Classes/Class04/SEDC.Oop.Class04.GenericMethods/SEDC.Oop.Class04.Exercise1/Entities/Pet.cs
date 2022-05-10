using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class04.Exercise1.Entities
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }

       public Pet(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }

        public abstract void PrintInfo();
    }
}
