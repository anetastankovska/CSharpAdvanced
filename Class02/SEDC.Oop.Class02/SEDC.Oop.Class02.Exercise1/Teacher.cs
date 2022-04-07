using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class02.Exercise1
{
    public class Teacher : User, ITeacher
    {

        public Teacher(int id, string name, string username, string password) : base(id, name, username, password)
        {
        }

        public string Subject { get; set; }

        public override void PrintUser()
        {
            base.PrintUser();
            Console.WriteLine(Subject);
        }
    }
}
