Console.Write("Enter a time value in 24-hour format (e.g. 19:00): ");
var input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Invalid Time");
    return;
}

var timeParts = input.Split(':');
if (timeParts.Length != 2)
{
    Console.WriteLine("Invalid Time");
    return;
}

var hour = int.Parse(timeParts[0]);
var minute = int.Parse(timeParts[1]);

if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
    Console.WriteLine("Ok");
else
    Console.WriteLine("Invalid Time");
