using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>();

        while (numbers.Count < 5)
        {
            Console.Write("Enter a number: ");
            var input = Console.ReadLine();
            var number = int.Parse(input);

            if (numbers.Contains(number))
            {
                Console.WriteLine("You've already entered " + number);
                continue;
            }

            numbers.Add(number);
        }

        numbers.Sort();

        Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers));
    }
}
