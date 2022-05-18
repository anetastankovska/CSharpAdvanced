// See https://aka.ms/new-console-template for more information
using Interfaces;
using Models;
using Services;
using Utils;

UserService svc = new UserService();

svc.Login<IStandardUser>("aa", "bb");

Console.WriteLine("Hello, World!");
List<string> a = Helpers.RegisterNewUser();
Console.WriteLine(a);