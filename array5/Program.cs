using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a list of comma-separated numbers: ");
        var input = Console.ReadLine();

        var numbers = new List<int>();
        foreach (var number in input.Split(','))
        {
            if (!int.TryParse(number.Trim(), out int parsedNumber))
            {
                Console.WriteLine("Invalid List");
                return;
            }
            numbers.Add(parsedNumber);
        }

        if (numbers.Count < 5)
        {
            Console.WriteLine("Invalid List");
            return;
        }

        numbers.Sort();

        Console.WriteLine("Smallest numbers:
