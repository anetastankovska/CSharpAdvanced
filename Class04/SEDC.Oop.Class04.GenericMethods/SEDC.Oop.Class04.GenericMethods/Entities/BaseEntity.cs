using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class04.GenericMethods.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}");
        }
    }
}
