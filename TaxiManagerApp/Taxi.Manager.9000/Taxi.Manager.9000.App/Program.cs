// See https://aka.ms/new-console-template for more information
using Taxi.Manager._9000.Data;
using Taxi.Manager._9000.Services.UserServices;

Console.WriteLine("Hello, World!");
UserService userService = new UserService();
//userService.Login();
string[] strings = { "a", "b", "2", "e" };
//foreach (string x in strings)
//{
//    if (!int.TryParse(x, out int value))
//    {
//        Console.WriteLine("The password is not valid. Please try again.");
//    }
//}

string input = "helloworld";
bool isDigitPresent = input.Any(c => char.IsDigit(c));


Console.WriteLine(isDigitPresent);