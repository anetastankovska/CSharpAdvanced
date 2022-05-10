using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class04.GenericMethods.Entities
{
    public class GenericMethods
    {
        public string MyProperty { get; set; }
        public void PrintObject<TFirst, TSecond>(TFirst objectToPrint, TSecond secondObject)
        {
            Console.WriteLine(objectToPrint);
            Console.WriteLine(secondObject);
            Console.WriteLine(typeof(TFirst));
            Console.WriteLine(typeof(TSecond));
        }
    }
}
