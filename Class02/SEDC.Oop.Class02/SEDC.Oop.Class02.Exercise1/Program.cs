// See https://aka.ms/new-console-template for more information

using SEDC.Oop.Class02.Exercise1;

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
