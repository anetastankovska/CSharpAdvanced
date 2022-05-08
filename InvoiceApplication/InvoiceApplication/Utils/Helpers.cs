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


    }
}
