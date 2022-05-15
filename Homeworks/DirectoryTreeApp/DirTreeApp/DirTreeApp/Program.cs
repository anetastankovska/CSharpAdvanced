// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string dirPath = @"C:\Users\Aneta\Desktop\SEDC\CSharpAdvanced";
Console.WriteLine(Directory.Exists(dirPath));
//string entries = "";
//Directory.GetFileSystemEntries(dirPath, out IEnumerable<string> entries);
//Console.WriteLine(entries);
//string[] files = Directory.GetFiles(dirPath);
//string[] filenames = files.Select(Path.GetFileName).ToArray();
//foreach (var file in filenames)
//{
//    Console.WriteLine(file);
//}

//Console.WriteLine("===============================================");

//string[] dirs = Directory.GetDirectories(dirPath);
//Console.WriteLine(dirs.Length);
//foreach (var dir in dirs)
//{
//    Console.WriteLine(Directory.GetDirectories(dir));

//    //Console.WriteLine($"-{dir}");
//}

//Console.WriteLine("++++++++++++++++++++++++++");

//string[] all = Directory.GetFileSystemEntries(dirPath);
//foreach (var item in all)
//{
//    Console.WriteLine(item);
//}

string PadSpaces(int level)
{
    string[] result = new string[level * 2];
    for (int i = 0; i < level; i++)
    {
        result[i] = "   ";
    }
    return string.Join("", result);
}

//string ColoredString(string text, ConsoleColor color)
//{
//    string strColor = "\u001b[__m";
//    strColor = strColor.Replace("__", color == ConsoleColor.Red ? "31" : color == ConsoleColor.Green ? "32" : "33");
//    return $"{strColor}{text}\u001b[0m";
//}

int level = 0;

void PrintinConsole(string path)
{
    level++;
    string[] files = Directory.GetFiles(path).Select(x => $"- {x.Split("\\").Last()}").ToArray();
    string[] dirs = Directory.GetDirectories(path);
    if (files.Length > 0)
    {
        foreach (var file in files)
        {
            Console.WriteLine(ColoredString($"{PadSpaces(level)}{file}", ConsoleColor.Green)); 
            //Console.WriteLine($"{PadSpaces(level)}{file}");
        }
    }

    if(dirs.Length > 0)
    {
        for (int i = 0; i < dirs.Length; i++)
        {
            Console.WriteLine(ColoredString($"{PadSpaces(level)}+ {dirs[i].Split("\\").Last()}", ConsoleColor.Red));
            //Console.WriteLine($"{PadSpaces(level)}+ {dirs[i].Split("\\").Last().ToUpper()}");
            PrintinConsole($"{dirs[i]}");
        }
    }
    level--;
}

PrintinConsole(dirPath);







