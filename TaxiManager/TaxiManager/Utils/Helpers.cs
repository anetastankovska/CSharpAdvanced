using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Helpers
    {
        public int ValidateInput(string username, string password, int min, int max)
        {

        }

        public string ColoredString(string text, ConsoleColor color)
        {
            string strColor = "\u001b[__m";
            strColor.Replace("__", color == ConsoleColor.Red ? "31" : color == ConsoleColor.Green ? "32" : "33");
            return $"{strColor}{text}\u001b[0m";
        }
    }
}
