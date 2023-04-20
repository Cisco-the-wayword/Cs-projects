using System;
using System.IO;

class WordCountFromFile
{
    static void Main()
    {
        Console.Write("Enter file path: ");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            int wordCount = content.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"The file '{filePath}' contains {wordCount} words.");
        }
        else
        {
            Console.WriteLine($"The file '{filePath}' does not exist.");
        }
    }
}
