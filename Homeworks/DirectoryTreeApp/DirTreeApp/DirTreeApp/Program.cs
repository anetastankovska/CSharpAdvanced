// See https://aka.ms/new-console-template for more information
using Interfaces;
using Logger;
using Models;

//string dirPath = @"C:\Users\Aneta\Desktop\SEDC\CSharpAdvanced";

// handling command line arguments
string dirPath = "'";
if (args.Length > 0)
{
    dirPath = args[0];
}
Ilogger logger = null;
try
{
    if (args.Length > 1)
    {
        logger = new LogWriter(args[1]);
    }
    else
    {
        logger = new LogWriter();
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    return;
}
// folder tree generation
TreeGenerator tree = TreeGenerator.Factory.CreateNew(logger);
if (tree != null)
{
    tree.TraverseFolder(dirPath);
}










