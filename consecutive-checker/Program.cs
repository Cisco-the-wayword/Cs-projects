using System;

class ConsecutiveChecker
{
    static void Main()
    {
        Console.Write("Enter a few numbers separated by a hyphen: ");
        var input = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(input))
            return;

        var numbers = input.Split('-');
        var isConsecutive = true;

        for (var i = 1; i < numbers.Length; i++)
        {
            if (Convert.ToInt32(numbers[i]) != Convert.ToInt32(numbers[i - 1]) + 1)
            {
                isConsecutive = false;
                break;
            }
        }

        var message = isConsecutive ? "Consecutive" : "Not Consecutive";
        Console.WriteLine(message);
    }
}
