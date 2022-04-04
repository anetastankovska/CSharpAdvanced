// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main (string[] args)
    {

        TextCounter();

        Console.ReadLine();

    }

    static int TextCounter()
    {
        Console.WriteLine("Enter a text below");
        List<string> textList = new List<string>();

        string userInput = string.Empty;


        while (userInput != "x")
        {
            userInput = Console.ReadLine();
            textList.Add(userInput);
        }

        Console.WriteLine("Please enter a text");
        string userText = Console.ReadLine();

        int counter = 0;
        foreach (string item in textList)
        {
            if () { }
        }

    }
}
