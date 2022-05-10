using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class04.GenericMethods.Entities
{
    public class GenericDB<T> where T : BaseEntity
    {
        private List<T> items;

        public GenericDB()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
            Console.WriteLine($"New item of type {typeof(T)} was added");
            //Console.WriteLine($"New item of type {item.GetType()} was added");
        }

        public void PrintInfo()
        {
            foreach (T item in items)
            {
                item.PrintInfo();
            }
        }

        public void DeleteItem(T itemToDelete)
        {
            T item = items.FirstOrDefault(x => x == itemToDelete);

            if(item != null)
            {
                items.Remove(item);
                Console.WriteLine($"Item with id {item.Id} was deleted");
            }
            else
            {
                Console.WriteLine("The item was not found.");
            }
        }
        
    }
}
