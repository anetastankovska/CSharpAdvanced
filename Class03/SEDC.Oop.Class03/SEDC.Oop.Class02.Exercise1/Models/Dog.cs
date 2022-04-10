using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class02.Exercise1.Models
{
    public class Dog
    {
        public int Id { get; set; } = -1;
        public string Name { get; set; }
        public string Color { get; set; }

        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public void Bark()
        {
            Console.WriteLine("Bark. bark!");
        }

        public static bool Validate(Dog dog)
        {
            if(dog.Id == -1) { return false; }
            if(string.IsNullOrEmpty(dog.Name)) { return false; }
            if(string.IsNullOrEmpty(dog.Color)) { return false; }
            if(dog.Name.Length < 2) { return false; }
            return true;
        }

        public override string ToString()
        {
            return $"Id: {Id}, name: {Name}, color: {Color}";
        }
    }
}
