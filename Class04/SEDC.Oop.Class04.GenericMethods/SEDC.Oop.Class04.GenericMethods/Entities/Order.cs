using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class04.GenericMethods.Entities
{
    public class Order : BaseEntity
    {
        public Product Product { get; set; }
        public string Address { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Product name: {Product}, address: {Address}");
        }

        public override string ToString()
        {
            return $"{Product.Title} {Address}";
        }
    }
}
