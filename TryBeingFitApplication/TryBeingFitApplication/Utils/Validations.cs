using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class Validations
    {
        public static int ValidateInput(int min, int max)
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine().Trim();
                    int parsedInput = int.Parse(input);

                    if(parsedInput < min || parsedInput > max)
                    {
                        Console.WriteLine("The input is out of range. Try again");
                        continue;
                    }
                    return parsedInput;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The input is not a valid number. Try again");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static string ValidateFirstName()
        {
            Console.WriteLine("Enter your first name. The name must be at least 2 characters long.");
            while (true)
            {
                try
                {
                    string firstName = Console.ReadLine().Trim();
                    //Regex.IsMatch(firstName, @"^[a-zA-Z]+$");
                    if (firstName.Length < 2)
                    {
                        Console.WriteLine("The length of the first name does not match the criteria.");
                        continue;
                    }
                    if (!firstName.Any(x => char.IsLetter(x)))
                    {
                        Console.WriteLine("The entered input is not a valid text. Try again.");
                        continue;
                    }
                    return firstName;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static string ValidateLastName()
        {
            Console.WriteLine("Enter your last name. The name must be at least 2 characters long.");
            while (true)
            {
                try
                {
                    string firstName = Console.ReadLine().Trim();
                    //Regex.IsMatch(firstName, @"^[a-zA-Z]+$");
                    if (firstName.Length < 2)
                    {
                        Console.WriteLine("The length of the last name does not match the criteria.");
                        continue;
                    }
                    if (!firstName.Any(x => char.IsLetter(x)))
                    {
                        Console.WriteLine("The entered input is not a valid text. Try again.");
                        continue;
                    }
                    return firstName;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static string ValidateUsername()
        {
            Console.WriteLine("Please enter your username. The username must be at least 6 characters long.");
            while (true)
            {
                try
                {
                    string username = Console.ReadLine().Trim();
                    if(username.Length < 6)
                    {
                        Console.WriteLine("The length of the username does not match the criteria. Try again.");
                        continue;
                    }
                    return username;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static string ValidatePassword()
        {
            
            Console.WriteLine("Please enter your password. \nThe password must be at least 6 characters long and must contain at least one digit, one letter and one special character.");
            while (true)
            {
                bool hasUppercase = false;
                bool hasDigit = false;
                bool hasSpecialChar = false;
                string password = Console.ReadLine().Trim();
                if(password.Length < 6)
                {
                    Console.WriteLine("The length of the password does not match the criteria. Try again.");
                    continue;
                }
                foreach (char c in password)
                {
                    if(!hasUppercase && char.IsUpper(c))
                    {
                        hasUppercase = true;
                    }
                    if(!hasDigit && char.IsDigit(c))
                    {
                        hasDigit = true;
                    }
                    if(!hasSpecialChar && !char.IsLetterOrDigit(c))
                    {
                        hasSpecialChar = true;
                    }
                }
                if (hasUppercase && hasDigit && hasSpecialChar)
                {
                    return password;
                }
                Console.WriteLine("The password does not match the criteria. Try again.");
            }
        }
    }
}
