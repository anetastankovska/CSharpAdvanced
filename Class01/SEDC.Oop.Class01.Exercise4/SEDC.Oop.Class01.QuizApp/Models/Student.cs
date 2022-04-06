using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.QuizApp.Models
{
    public class Student : User
    {
        public bool TestDone { get; set; }
        public int Grade { get; set; }

        public Student() { }

        public Student(string name, string username, string password)
            : base(name, username, password)
        {
            TestDone = false;
            Grade = 0;
        }

        public int showGrade()
        {
            Console.WriteLine($"Your grade is {Grade}");
            return Grade;
        }
    }
}
