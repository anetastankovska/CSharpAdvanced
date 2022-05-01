using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Helpers
    {
        public int ValidateInput(string input, int min, int max)
        {
            int choice = int.MinValue;
            bool isValidNumber = int.TryParse(input, out choice);
            if (int.TryParse(input, out choice) && (choice < min || choice > max))
            {
                return -1;
            }
            return choice;
        }

        public int ReturnValidChoice(int min, int max)
        {
            while (true)
            {
                try
                {
                    string choice = Console.ReadLine();
                    int parsedChoice = int.Parse(choice);
                    if (parsedChoice >= min && parsedChoice <= max)
                    {
                        return parsedChoice;
                    }
                    printWithColor("The selected option is not valid. Try again", ConsoleColor.Red);
                }
                catch (Exception)
                {
                    printWithColor("The selected option is not valid. Try again", ConsoleColor.Red);
                }
            }
        }

        public bool ValidateUsername(string username)
        {
            if (username.Length >= 5)
            {
                return true;
            }
            return false;
        }

        public bool ValidatePassword(string password)
        {
            if (password.Any(c => char.IsDigit(c)) && password.Length >= 5)
            {
                return true;
            }
            return false;
        }

        public List<string> CreateNewUser()
        {
            List<string> credentials = new List<string>();
            while (true)
            {
                Console.Clear();
                credentials.Clear();
                try
                {
                    Console.WriteLine("Please enter a unsername");
                    string username = Console.ReadLine();
                    Console.WriteLine("Pease enter a password");
                    string password = Console.ReadLine();

                    if (ValidateUsername(username) && ValidatePassword(password))
                    {
                        printWithColor("Valid username and password", ConsoleColor.Green);
                        credentials.Add(username);
                        credentials.Add(password);
                    }
                    else
                    {
                        printWithColor("The given credentials are not valid. Press enter to try again", ConsoleColor.Red);
                        Console.ReadLine();
                        continue;
                    }
                    Console.Clear();
                    Console.WriteLine("Select a role: \n1. Administrator \n2. Manager \n3. Maintainance");
                    int choice = ReturnValidChoice(1, 3);
                    string chosenStr = choice.ToString();
                    credentials.Add(chosenStr);
                    break;
                }
                catch (Exception)
                {
                    Console.Clear();
                    printWithColor("The given credentials are not valid. Press enter to try again", ConsoleColor.Red);
                    Console.ReadLine();
                }
            }
            return credentials;
        }

        public string RequestPassChange(string oldPass)
        {
            Console.WriteLine("Please enter your old password");
            string enteredPass = Console.ReadLine();
            while (enteredPass != oldPass)
            {
                Console.Clear();
                Console.WriteLine("The password does not match. Please try again");
                oldPass = Console.ReadLine();
            }
            Console.WriteLine("Please enter the new password. The password must be at least 5 characters long and must contain at least one number.");
            string newPassword = Console.ReadLine();
            while (!ValidatePassword(newPassword))
            {
                Console.Clear();
                printWithColor("The password does not match the criteria. Try another one.", ConsoleColor.Red);
                newPassword = Console.ReadLine();
            }
            printWithColor("The password is valid", ConsoleColor.Green);
            return newPassword;


        }

        public void LogoutMock()
        {
            Console.Write("Logging out");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
        }

        public string ColoredString(string text, ConsoleColor color)
        {
            string strColor = "\u001b[__m";
            strColor = strColor.Replace("__", color == ConsoleColor.Red ? "31" : color == ConsoleColor.Green ? "32" : "33");
            return $"{strColor}{text}\u001b[0m";
        }


        public Action<string, ConsoleColor> printWithColor = (text, color) =>
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        };

        public void RedirectToMenu(Func<int> menu, string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
            Console.Clear();
            menu.Invoke();
        }

        
    }
}
