using System;

class TimeValidator
{
    static void Main()
    {
        Console.Write("Enter a time value in the 24-hour time format (e.g. 19:00): ");
        var input = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid Time");
            return;
        }

        var time = new TimeSpan();
        if (TimeSpan.TryParse(input, out time))
        {
            Console.WriteLine("Ok");
        }
        else
        {
            Console.WriteLine("Invalid Time");
        }
    }
}
