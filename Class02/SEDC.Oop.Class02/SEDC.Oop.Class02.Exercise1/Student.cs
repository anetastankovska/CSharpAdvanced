using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class02.Exercise1
{
    public class Student : User, IStudent
    {
        public Student(int id, string name, string username, string password) : base(id, name, username, password)
        {
        }

        public List<int> Grades { get; set; }

        public override void PrintUser()
        {
            base.PrintUser();
            foreach(int grade in Grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
