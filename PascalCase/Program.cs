using System;

class PascalCaseConverter
{
    static void Main()
    {
        Console.Write("Enter a few words separated by a space: ");
        var input = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(input))
            return;

        var words = input.Split(' ');
        var variableName = "";

        foreach (var word in words)
        {
            var pascalWord = char.ToUpper(word[0]) + word.Substring(1).ToLower();
            variableName += pascalWord;
        }

        Console.WriteLine(variableName);
    }
}
