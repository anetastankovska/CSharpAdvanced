// See https://aka.ms/new-console-template for more information


SayDelegate sayDelegate = new SayDelegate(WriteToConsole);
SayDelegate sayWithColor = new SayDelegate(WriteWithRedColor);

sayDelegate("Hello world from delegate");
sayWithColor("This text is red");

SaySomething(WriteToConsole, 1);
SaySomething(WriteWithRedColor, 2);

CalculateDelegate addTwoNumbers = AddNumbers;
Console.WriteLine($"4 + 5 = {addTwoNumbers(4, 5)}");

CalculateDelegate subtractTwoNumbers = SubtractNumbers;
Console.WriteLine($"10 - 3 = {SubtractNumbers(10, 3)}");

PerformCalculations(AddNumbers, SubtractNumbers, 6, 7);

static void WriteToConsole(string text)
{
    Console.WriteLine(text);
}

static void WriteWithRedColor(string text)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ResetColor();
}

static void SaySomething(SayDelegate sayMechanism, int counter)
{
    sayMechanism($"Text from method {counter}");
}

static void PerformCalculations(CalculateDelegate addNumbers, CalculateDelegate subtractNumbers, int first, int second)
{
    Console.WriteLine($"Addition of {first} and {second} is {addNumbers(first, second)}");
    Console.WriteLine($"Subtraction of {first} and {second} is {subtractNumbers(first, second)}");
}

static int AddNumbers(int firstNumber1, int secondNumber1)
{
    return firstNumber1 + secondNumber1;
}

static int SubtractNumbers(int firstNumber, int secondNumber)
{
    return firstNumber - secondNumber;
}

delegate void SayDelegate(string text);
delegate int CalculateDelegate(int firstNumber, int secondNumber);