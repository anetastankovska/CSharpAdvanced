using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.QuizApp.Models
{
    public class Teacher : User
    {
        Dictionary<Student, int> Students { get; set; }

        public Teacher() { }
        public Teacher(string firstName, string lastName, string userName, string password)
            : base(firstName, lastName, userName, password)
        {
            Students = new Dictionary<Student, int>();
        }

        public void ShowStudents()
        {

        }
    }
}
