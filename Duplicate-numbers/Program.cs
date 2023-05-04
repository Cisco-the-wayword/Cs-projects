using System;
using System.Linq;

class MainClass
{
	public static void Main(string[] args)
	{
		Console.Write("Enter a few numbers separated by a hyphen: ");
		var input = Console.ReadLine();

		if (string.IsNullOrWhiteSpace(input))
		{
			Console.WriteLine("Exiting program");
			return;
		}

		var numbers = input.Split('-').Select(int.Parse).ToArray();

		if (numbers.Length != numbers.Distinct().Count())
		{
			Console.WriteLine("Duplicate");
		}
		else
		{
			Console.WriteLine("No duplicates");
		}
	}
}
