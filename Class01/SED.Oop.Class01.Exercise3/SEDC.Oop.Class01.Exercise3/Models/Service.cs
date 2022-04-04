using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.Exercise3.Models
{
    public class Service
    {

        public int SelectRandomNum()
        {
            Random rnd = new Random();
            int selected = rnd.Next(1, 3);
            return selected;
        }

        public int ValidateInput(int min, int max)
        {
            int result = int.MinValue;
            string input = Console.ReadLine();
            while (int.TryParse(input, out result) && result < min && result > max)
            {
                Console.WriteLine("Please enter a valid input.");
                input = Console.ReadLine();
            }
            return result;

        }

        public void ShowPicks(int userNum)
        {
            int computerNum = SelectRandomNum();
            switch (userNum)
            {
                case 1:
                    Console.WriteLine("The user selection is Rock");
                    break;
                case 2:
                    Console.WriteLine("The user selection is Paper");
                    break;
                case 3:
                    Console.WriteLine("The user selection is Scissors");
                    break;
                default:
                    break;
            }

            switch (computerNum)
            {
                case 1:
                    Console.WriteLine("The computer selection is Rock");
                    break;
                case 2:
                    Console.WriteLine("The computer selection is Paper");
                    break;
                case 3:
                    Console.WriteLine("The computer selection is Scissors");
                    break;
                default:
                    break;
            }

        }

        

    }
}
