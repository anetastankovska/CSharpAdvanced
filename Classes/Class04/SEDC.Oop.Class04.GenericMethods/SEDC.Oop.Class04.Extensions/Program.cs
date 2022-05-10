// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");

Console.WriteLine(StringExtensions.DeleteClassCharacterClassic("String to shorten"));

string textShorten = "SomeStringValue";
string shortString = StringExtensions.DeleteClassCharacterClassic(textShorten);
Console.WriteLine(textShorten.DeleteClassCharacter());

string textToQuote = "Quoted text";

Console.WriteLine(textToQuote.AddQuotations());

List<string> list = new List<string>() { "first", "second", "third", "fourth", "fifth" };
list.PrintElements();
