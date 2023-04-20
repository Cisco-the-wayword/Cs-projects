using System;
using System.IO;
using System.Linq;

class LongestWordFromFile
{
    static void Main()
    {
        Console.Write("Enter file path: ");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            string[] words = content.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();
            Console.WriteLine($"The longest word in the file '{filePath}' is '{longestWord}'.");
        }
        else
        {
            Console.WriteLine($"The file '{filePath}' does not exist.");
        }
    }
}
