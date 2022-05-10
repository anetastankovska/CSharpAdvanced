using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class04.Exercise1.Entities
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }
        public string FavoriteFood { get; set; }

        public Dog(string name, string type, int age, string favoriteFood)
            :base(name, type, age)
        {
            FavoriteFood = favoriteFood;
            GoodBoy = true;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name}'s favorite food is {FavoriteFood}");
        }
    }
}
