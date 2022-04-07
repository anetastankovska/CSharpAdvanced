using SEDC.Oop.Class01.QuizApp.Databases;
using SEDC.Oop.Class01.QuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.QuizApp.Services
{
    public class Quiz
    {
        static void Main(string[] args)
        {

        }

        public QuizDatabase QuizRepo { get; set; }
        public User CurrentUser { get; set; }

        public Quiz() { }

        public Quiz(QuizDatabase quizRepo)
        {
            QuizRepo = quizRepo;
        }

        QuizDatabase database = new QuizDatabase();

        public void MainMenu()
        {
            while (CurrentUser == null)
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Welcome to the School Quiz. \nEnter your username and password to continue");
                CurrentUser = Login();
                if(CurrentUser == null)
                {
                    continue;
                }
                if (CurrentUser.GetType() == typeof(Teacher))
                {
                    (CurrentUser as Teacher).ShowStudents(GetStudents());
                }
                else
                {
                    Student student = CurrentUser as Student;
                    if (student.TestDone)
                    {
                        Console.WriteLine($"{student.Name}, you have already done the test.");
                        student.showGrade();
                    }
                    else
                    {
                        StartQuiz();
                    }
                }
                Console.ReadLine();
                Logout();
            }
        }

        public User Login()
        {
            Console.WriteLine("Username:");
            string username = Console.ReadLine();
            bool isValidPassword = false;
            User loggedUser = database.Users.FirstOrDefault(x => x.UserName == username);
            if (loggedUser == null)
            {
                Console.WriteLine("The username has not been found in the system. Try again.");
                return loggedUser;
            }
            Console.WriteLine("Password");
            string password = Console.ReadLine();
            isValidPassword = loggedUser.CheckPassword(password);
            if (!isValidPassword)
            {
                Console.WriteLine("The password isn't valid. Try again.");
                return null;
            }
            Console.WriteLine("Logged in");
            Thread.Sleep(1000);
            return loggedUser;


        }

        public void ShowOptions(Type userType)
        {
            if (userType == typeof(Teacher))
            {
                List<Student> students = database.Users.Where(x => x.GetType() == typeof(Student)).Select(x => x as Student).ToList();
                (CurrentUser as Teacher).ShowStudents(students);
                Console.WriteLine("Press any enter to continue...");
                Console.ReadLine();
                Logout();
            }
            else
            {
                if ((CurrentUser as Student).TestDone)
                {
                    Console.WriteLine("You already did the test. You cannot retake it");
                    Logout();
                }
                else
                {
                    StartQuiz();
                    Logout();
                }
            }
        }

        private void StartQuiz()
        {
            Student student = CurrentUser as Student;
            foreach (Question q in database.Questions)
            {
                bool correctAns = AskQuestion(q);
                student.Grade += correctAns ? 1 : 0;
            }
            student.TestDone = true;
            student.showGrade();
        }

        public string ShowQuestion(Question q)
        {
            Console.Clear();
            string fullQuestion = q.Text;
            
            foreach (string option in q.Answers)
            {
                fullQuestion += $"\n{option} ";
            }
            return fullQuestion;
        }

        public bool AskQuestion(Question q)
        {
            Console.WriteLine(ShowQuestion(q));
            string choice = HandleInput("a", "b", "c", "d");
            return q.isAnswerCorrect(choice);
        }

        public void Logout()
        {
            CurrentUser = null;
            Console.WriteLine("You have been logged out");
        }

        public int HandleInput(int min, int max)
        {
            Console.Write("Please select an option:");
            string input = Console.ReadLine();
            bool isValidInt = int.TryParse(input, out int validInt);
            while (validInt < min || validInt > max)
            {
                Console.WriteLine("The input is not valid. Try again");
                input = Console.ReadLine();
                isValidInt = int.TryParse(input, out validInt);
            }
            return validInt;
        }


        public string HandleInput(params string[] options)
        {
            Console.Write("Please select an option:");
            string input = Console.ReadLine();

            while (!options.Select(x => x.ToLower()).Contains(input.ToLower()))
            {
                Console.WriteLine("The input is not valid. Try again");
                input = Console.ReadLine();
            }
            return options.FirstOrDefault(x => x.ToLower() == input.ToLower());
        }

        public List<Student> GetStudents()
        {
            List<Student> students = database.Users
                .Where(x => x.GetType() == typeof(Student))
                .Select(x => x as Student).ToList();
            return students;
        }


    }

}
