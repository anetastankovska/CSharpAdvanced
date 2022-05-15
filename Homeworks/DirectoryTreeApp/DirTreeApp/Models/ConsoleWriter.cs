using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Models
{
    public class ConsoleWriter
    {
        public int level { get; set; } = 0;

        public void PrintinConsole(string path)
        {
        //int level = 0;
        level++;
            string[] files = Directory.GetFiles(path).Select(x => $"- {x.Split("\\").Last()}").ToArray();
            string[] dirs = Directory.GetDirectories(path);
            if (files.Length > 0)
            {
                foreach (var file in files)
                {
                    Console.WriteLine(Helpers.ColoredString($"{Helpers.PadSpaces(level)}{file}", ConsoleColor.Green));
                    //Console.WriteLine($"{PadSpaces(level)}{file}");
                }
            }

            if (dirs.Length > 0)
            {
                for (int i = 0; i < dirs.Length; i++)
                {
                    Console.WriteLine(Helpers.ColoredString($"{Helpers.PadSpaces(level)}+ {dirs[i].Split("\\").Last()}", ConsoleColor.Red));
                    //Console.WriteLine($"{PadSpaces(level)}+ {dirs[i].Split("\\").Last().ToUpper()}");
                    PrintinConsole($"{dirs[i]}");
                }
            }
            level--;
        }
    }
}
