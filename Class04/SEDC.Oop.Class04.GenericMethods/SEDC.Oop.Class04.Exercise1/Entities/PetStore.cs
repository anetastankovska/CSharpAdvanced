using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class04.Exercise1.Entities
{
    public class PetStore<T> where T : Pet
    {
        private List<T> Pets = new List<T>();

        public void PrintPets()
        {
            foreach (T pet in Pets)
            {
                pet.PrintInfo();
            }
        }

        public void BuyPet(string name)
        {
            T pet = Pets.FirstOrDefault(x => x.Name == name);
            Pets.Remove(pet);
            Console.WriteLine("The pet was successfully bought");
        }

        public void Add(T pet)
        {
            Pets.Add(pet);
        }
    }
}
