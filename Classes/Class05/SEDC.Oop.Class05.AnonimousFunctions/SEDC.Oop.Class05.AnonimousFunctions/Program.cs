// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("======================Function======================");
Func<string, bool> isValidNumber = text => int.TryParse(text, out int parsed);

Func<int> getRandomNumber = () =>
{
    Random random = new Random();
    return random.Next(1, 100);
};


int randomNumber = getRandomNumber();
Console.WriteLine(randomNumber);


//Regular method
 static int GetRandomNumber()
{
    Random random = new Random();
    return random.Next(1, 100);
}

Func<int, int, int> addTwoNumbers = (firstNumber, secondNumber) =>
{
    return firstNumber + secondNumber;
};

Console.WriteLine("Enter two numbers: ");

int first;
int second;
string firstString = Console.ReadLine();
if (isValidNumber(firstString))
{
    first = int.Parse(firstString);
}
else
{
    Console.WriteLine("The second number was not valid");
    return;
}

string secondString = Console.ReadLine();
if (isValidNumber(secondString))
{
    second = int.Parse(secondString);
}
else
{
    Console.WriteLine("The second number was not valid");
    return;
}

Console.WriteLine($"The addition of the two numbers is {addTwoNumbers(first, second)}");

Console.WriteLine("====================Action=====================");
Action<string> printWithRedColor = (text) =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ResetColor();
};

printWithRedColor("This is error message");

Action<string, ConsoleColor> printWithColor = (text, color) =>
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
};

printWithColor("BlueText", ConsoleColor.Blue);
printWithColor("Green text", ConsoleColor.Green);

Action printHelloMessage = () => Console.WriteLine("Hello from anonimous method");

printHelloMessage();