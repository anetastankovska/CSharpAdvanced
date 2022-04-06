using SEDC.Oop.Class01.QuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.QuizApp.Databases
{
    public class QuizDatabase
    {
        public List<User> Users { get; set; } = new List<User>();
        public List<Question> Questions { get; set; } = new List<Question>();

        public QuizDatabase()
        {
            InitializeData();
        }

        private void  InitializeData()
        {
            Users.Add(new Teacher("Ivan", "teacher1", "t1234"));
            Users.Add(new Teacher("Vlatko", "teacher2", "t2345"));
            Users.Add(new Student("Aneta", "student1", "s1234"));
            Users.Add(new Student("Stefan", "student2", "s2345"));
            Users.Add(new Student("Aleksandar", "student3", "s3456"));
            Users.Add(new Student("Maja", "student4", "s4567"));
            Users.Add(new Student("Ana", "student5", "s5678"));

            Questions.Add(new Question("1. Q: What is the capital of Tasmania?", new string[]{ "a: Dodoma", "b: Hobart", "c: Launceston", "d: Wellington" }, "b: Hobart"));
            Questions.Add(new Question("2. Q: What is the tallest building in the Republic of the Congo?", new string[] { "a: Kinshasa Democratic Republic of the Congo Temple", "b: Palais de la Nation", "c: Kongo Trade Centre", "d: Nabemba Tower" }, "d: Nabemba Tower"));
            Questions.Add(new Question("3. Q: Which of these is not one of Pluto's moons?", new string[] { "a: Styx", "b: Hydra", "c: Nix", "d: Lugia" }, "c: Nix"));
            Questions.Add(new Question("4. Q: What is the smallest lake in the world?", new string[] { "a: Onega Lake", "b: Benxi Lake", "c: Kivu Lake", "d: Wakatipu Lake" }, "b: Benxi Lake"));
            Questions.Add(new Question("5. Q: What country has the largest population of alpacas?", new string[] { "a: Chad", "b: Peru", "c: Australia", "d: Niger" }, "b: Peru"));
        }

    }
}
