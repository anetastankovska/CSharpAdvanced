// See https://aka.ms/new-console-template for more information
using Interfaces;
using Models;
using Services;
using Utils;

UserService svc = new UserService();

var ints = new List<int>() { 1, 2, 3, 4, 5 };
string result = string.Join("\n", ints);
Console.WriteLine(result);