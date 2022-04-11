using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class04.GenericMethods.Entities
{
    public class NonGenericHelper
    {
        public void GoThrougList(List<string> strings)
        {
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }

        public void GetInfoForList(List<string> strings)
        {
            Console.WriteLine($"The list has {strings.Count} and the elements are of type {strings[0].GetType()}");
        }

        public void GoThrougList(List<int> intList)
        {
            foreach (int i in intList)
            {
                Console.WriteLine(i);
            }
        }

        public void GetInfoForList(List<int> intList)
        {
            Console.WriteLine($"The list has {intList.Count} and the elements are of type {intList[0].GetType()}");
        }
    }
}
