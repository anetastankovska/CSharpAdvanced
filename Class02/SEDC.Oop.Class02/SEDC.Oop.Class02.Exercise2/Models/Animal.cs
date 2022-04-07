using SEDC.Oop.Class02.Exercise2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class02.Exercise2.Models
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public Animal(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public void PrintAnimal() { }

        
    }
}
