using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Models
{
    public class TreeGenerator
    {
        public int Level { get; set; }

        public Ilogger Logger { get; protected set; }

        public class Factory
        {
            public static TreeGenerator CreateNew(Ilogger logger)
            {
                try
                {
                    TreeGenerator treeGenerator = new TreeGenerator() { Logger = logger };
                    return treeGenerator;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public void TraverseFolder(string path)
        {
            try
            {
                Level++;
                string[] files = Directory.GetFiles(path).Select(x => $"{x.Split("\\").Last()}").ToArray();
                string[] dirs = Directory.GetDirectories(path);
                if (files.Length > 0)
                {
                    foreach (var file in files)
                    {
                        string temp = $"{Helpers.PadSpaces(Level)}├─── {Helpers.ColoredString(file, ConsoleColor.Green)}";
                        Logger.LogMessage(temp);
                    }
                }

                if (dirs.Length > 0)
                {
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        string temp = $"{Helpers.PadSpaces(Level)}└─── {Helpers.ColoredString(dirs[i].Split("\\").Last(), ConsoleColor.Red)}";
                        Logger.LogMessage(temp);
                        TraverseFolder($"{dirs[i]}");
                    }
                }
                Level--;
            }
            catch (Exception ex)
            {
                Logger.LogMessage(ex.Message);
            }
        }

    }
}
