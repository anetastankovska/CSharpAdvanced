using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.QuizApp.Models
{
    public class Student : User
    {
        public int Grade { get; set; }
        public bool TestDone { get; set; }

        public Student() { }

        public Student(string firstName, string lastName, string username, string password)
            : base(firstName, lastName, username, password)
        {
            Grade = 0;
            TestDone = false;
        }

        public int showGrade()
        {
            Console.WriteLine($"Your grade is {Grade}");
            return Grade;
        }
    }
}
