// See https://aka.ms/new-console-template for more information

List<int> intList = new List<int> { 5, 6, 1, 4, 19, 32, 8, 14 };

var largerThanTen = intList.Where(number => number > 10).ToList();
largerThanTen.ForEach(number => Console.WriteLine(number));

static bool IsLargerThanTen(int number)
{
    return number > 10;
}
var largerThanTen2 = intList.Where(IsLargerThanTen).ToList();

List<string> stringList = new List<string> { "12", "2", "6", "23", "44", "5", "8", "15", "a"};

List<int> convertedList = stringList.Select((stringNumber) =>
{
    int number;
    int.TryParse(stringNumber, out number);
    return number;
}).ToList();

convertedList.ForEach(x => Console.WriteLine(x));
