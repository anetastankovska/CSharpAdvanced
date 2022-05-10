using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class02.Exercise1.Models
{
    public static class DogShelter
    {
        public static List<Dog> Dogs { get; set; } = new List<Dog>();

        public static void PrintAllDogs()
        {
            foreach (Dog dog in Dogs)
            {
                Console.WriteLine(dog);
            }
        }
        public static void AddDog(int id, string name, string color)
        {
            Dog dog = new Dog(id, name, color);
            Dogs.Add(dog);
            PrintAllDogs();
        }

        public static void GetDogData()
        {
            Console.WriteLine("Enter dog details in comma separated format(id, name, color)");
            string rawInput = Console.ReadLine();
            string[] words = rawInput.Split(",");
            while(words.Length < 3)
            {
                Console.WriteLine("The input is not valid");
                rawInput = Console.ReadLine();
                words = rawInput.Split(",");
            }
            bool isValidId = int.TryParse(words[0], out int parsedId);
            string name = words[1];
            string color = words[2];
            while(!isValidId || parsedId == 0 || name.Length < 2)
            {
                Console.WriteLine("The input is not valid, try again");
                rawInput = Console.ReadLine();
                words = rawInput.Split(",");
                while (words.Length < 3)
                {
                    Console.WriteLine("The input is not valid");
                    rawInput = Console.ReadLine();
                    words = rawInput.Split(",");
                }
                isValidId = int.TryParse(words[0], out parsedId);
                name = words[1];
                color = words[2];
            }
            AddDog(parsedId, name, color); 

        }

        public static void GetDogData1()
        {
            while (true)
            {
                Console.WriteLine("Enter dog details in comma separated format(id, name, color)");
                string rawInput = Console.ReadLine();
                string[] words = rawInput.Split(",");
                int.TryParse(words[0], out int id);
                try
                {
                    Dog dog = new Dog(id, words[1], words[2]);
                    if (Dog.Validate(dog))
                    {
                        DogShelter.Dogs.Add(dog);
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error occured while adding dog");
                } 
            }
        }
    }
}
