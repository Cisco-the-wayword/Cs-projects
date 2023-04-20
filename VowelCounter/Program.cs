using System;
using System.Linq;

class VowelCounter
{
    static void Main()
    {
        Console.Write("Enter an English word: ");
        var input = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(input))
            return;

        var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
        var vowelCount = input.Count(c => vowels.Contains(char.ToLower(c)));

        Console.WriteLine(vowelCount);
    }
}
