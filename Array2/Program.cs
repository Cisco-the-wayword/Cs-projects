using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        var name = Console.ReadLine();

        var reversed = new char[name.Length];
        for (int i = 0, j = name.Length - 1; i <= j; i++, j--)
        {
            reversed[i] = name[j];
            reversed[j] = name[i];
        }

        var reversedName = new string(reversed);
        Console.WriteLine("Reversed name: " + reversedName);
    }
}
