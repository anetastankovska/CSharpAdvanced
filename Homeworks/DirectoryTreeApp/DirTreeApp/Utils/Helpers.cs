using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Helpers
    {
        public static string ColoredString(string text, ConsoleColor color)
        {
            string strColor = "\u001b[__m";
            strColor = strColor.Replace("__", color == ConsoleColor.Red ? "31" : color == ConsoleColor.Green ? "32" : "33");
            return $"{strColor}{text}\u001b[0m";
        }

        public static string PadSpaces(int level)
        {
            string[] result = new string[level * 2];
            for (int i = 0; i < level; i++)
            {
                result[i] = "│   ";
            }
            return string.Join("", result);
        }
    }
}
