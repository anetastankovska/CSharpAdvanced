using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.QuizApp.Models
{
    public class Teacher : User
    {
        public Teacher() { }
        public Teacher(string name, string userName, string password)
            : base(name, userName, password)
        {
            
        }

        public void ShowStudents(List<Student> students)
        {
            Console.WriteLine($"Welcome to your account {Name}!");
            Console.WriteLine("Your students: \n");
            foreach(Student student in students)
            {
                if (!student.TestDone)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Student: {student.Name}");
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine($"Student: {student.Name}, grade: {student.Grade}" );
                }
            }
            Console.ResetColor();
        }
    }
}
