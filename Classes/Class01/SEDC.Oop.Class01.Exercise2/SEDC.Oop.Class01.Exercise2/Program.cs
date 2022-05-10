// See https://aka.ms/new-console-template for more information


public class Program
{
    public static void Main(string[] args)
    {
        string answer = "yes";
        while (answer == "yes")
        {
            Console.WriteLine("Enter a date in dd/mm/yyyy format");
            string userInput = Console.ReadLine();
        
            CheckWorkingDay(userInput);
            Console.WriteLine("Do you want to continue");
            answer = Console.ReadLine();
        }

        if (answer == "no")
        {
            Console.WriteLine("Thank you for using our app");
            return;
        }
    }

    public static void CheckWorkingDay(string dateStr)
    {
        bool isParsedDate = DateTime.TryParse(dateStr, out DateTime parsedDate);

        if (parsedDate.DayOfWeek == DayOfWeek.Saturday || parsedDate.DayOfWeek == DayOfWeek.Sunday) 
        {
            Console.WriteLine("The entered date is a non-working day!");
        }
        else if(parsedDate.Month == 1 && parsedDate.Day == 1)
        {
            Console.WriteLine("Non working day");
        }
        else if(parsedDate.Month == 1 && parsedDate.Day == 7)
        {
            Console.WriteLine("Non working day");
        }
        else if (parsedDate.Month == 4 && parsedDate.Day == 20)
        {
            Console.WriteLine("Non working day");
        }
        else if (parsedDate.Month == 5 && parsedDate.Day == 1)
        {
            Console.WriteLine("Non working day");
        }
        else if (parsedDate.Month == 5 && parsedDate.Day == 25)
        {
            Console.WriteLine("Non working day");
        }
        else if (parsedDate.Month == 8 && parsedDate.Day == 3)
        {
            Console.WriteLine("Non working day");
        }
        else if (parsedDate.Month == 9 && parsedDate.Day == 8)
        {
            Console.WriteLine("Non working day");
        }
        else if (parsedDate.Month == 10 && parsedDate.Day == 12)
        {
            Console.WriteLine("Non working day");
        }
        else if (parsedDate.Month == 10 && parsedDate.Day == 23)
        {
            Console.WriteLine("Non working day");
        }
        else if (parsedDate.Month == 12 && parsedDate.Day == 8)
        {
            Console.WriteLine("Non working day");
        }
        else
        {
            Console.WriteLine("The selected day is a working day");
        }


    }

    
}

