using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class03.Polymorphism.Entities
{
    public class MethodPoly
    {
        public int AddNumbers(int first, int second)
        {
            return first + second;
        }

        public int AddNumbers(int first, int second, int third)
        {
            return first + second + third;
        }

        public void AddNumbers(double first, double second)
        {
            Console.WriteLine(first + second);
        }

        public void AddNumbers(params int[] a)
        {
            
        }
    }

}
