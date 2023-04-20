using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter a number (or type 'Quit' to exit): ");
            var input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            var number = int.Parse(input);

            if (!numbers.Contains(number))
            {
                numbers.Add(number);
            }
        }

        Console.WriteLine("Unique numbers: " + string.Join(", ", numbers));
    }
}
