// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main (string[] args)
    {

        TextCounter();


        Console.ReadLine();

    }

    static void TextCounter()
    {
        
        List<string> names = new List<string>();

        do
        {
            string name = string.Empty;
            Console.WriteLine("Enter a namew");
            if (name.ToLower() == "x")
            {
                break;
            }
            else
            {
                names.Add(name);
            }
        }
        while (name.ToLower() == "x");

        Console.WriteLine("Please enter a text");

        string enteredText = Console.ReadLine();

        string[] enteredWords = enteredText.Split(' ');

        foreach (string name in names)
        {
            int counter = 0;
            foreach(string word in enteredWords)
            {
                if(word.ToLower() == name.ToLower())
                {
                    counter++;
                }
            }
            Console.WriteLine($"string {name}: {counter}");
            
        }
    }
}
