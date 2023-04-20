using System;
using System.Linq;

class DuplicateChecker
{
    static void Main()
    {
        Console.Write("Enter a few numbers separated by a hyphen: ");
        var input = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(input))
            return;

        var numbers = input.Split('-');
        var hasDuplicates = numbers.Length != numbers.Distinct().Count();

        var message = hasDuplicates ? "Duplicate" : "";
        Console.WriteLine(message);
    }
}
