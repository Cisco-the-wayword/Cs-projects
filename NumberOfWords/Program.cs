using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        int wordCount = CountWords(sentence);

        Console.WriteLine($"The sentence contains {wordCount} words.");
    }

    static int CountWords(string sentence)
    {
        string[] words = sentence.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
