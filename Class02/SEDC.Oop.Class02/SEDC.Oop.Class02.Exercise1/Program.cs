// See https://aka.ms/new-console-template for more information

using SEDC.Oop.Class02.Exercise1;

// ●Create an interfaces  called IUser, IStudent, ITeacher
//    ▹IUser : Id, Name, Username, Password, PrintUser() - Prints Id, Name and Username
//    ▹IStudent:  Grades, override PrintUser() to show grades
//    ▹ITeacher : Subject, override PrintUser() to show subject
// ●Create an abstract class User and inherits from IUser
// ●Create a class Student  that inherits from User and IStudent
// ●Create a class Teacher  that inherits from User and ITeacher
// ●Create 2 teacher and 2 student  objects and call PrintUser() on all of them

IUser teacher = new Teacher()
{
    Id = 1,
    Name = "Ivan",
    Username = "ivan",
    Password = "pass1",
    Subject = "C# Advanced"
};

IUser student = new Student()
{
    Id = 2,
    Name = "Aneta",
    Username = "aneta",
    Password = "pass2",
    Grades = new List<int>()
};

teacher.PrintUser();
student.PrintUser();
