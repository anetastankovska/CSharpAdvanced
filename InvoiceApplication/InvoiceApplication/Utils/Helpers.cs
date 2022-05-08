using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class Helpers
    {
        public static int ValidadeInput(int min, int max)
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    int parsedInt = int.Parse(input);
                    if (parsedInt >= min && parsedInt <= max)
                    {
                        return parsedInt;
                    }
                    Console.WriteLine("The input is not valid. Please try again");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static int CheckDeposit()
        {
            Console.WriteLine("Please enter amount between 1 and 100000");
            
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    int parsedInt = int.Parse(input.Trim());
                    if(parsedInt > 1 && parsedInt < 100000)
                    {
                        return parsedInt;
                    }
                    Console.WriteLine("The entered amount is not valid. Please try again");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


    }
}
