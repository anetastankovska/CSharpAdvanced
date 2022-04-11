using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class04.GenericMethods.Entities
{
    public class GenericHelper
    {
        public void GoThroughList<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void GetInfoForList<T>(List<T> list)
        {
            Console.WriteLine($"Thee are {list.Count} elements of type {typeof(T)}");
        }
    }
}
