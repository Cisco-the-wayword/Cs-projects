using System;

class MainClass
{
    static bool isPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter n1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter n2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        if (n1 <= n2)
        {
            Console.WriteLine("n1 should be greater than n2");
        }
        else
        {
            bool hasPrime = false;
            Console.WriteLine("Prime numbers between {0} and {1} are:", n1, n2);
            for (int i = n2; i <= n1; i++)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i);
                    hasPrime = true;
                }
            }
            if (!hasPrime) Console.WriteLine("No prime number exists");
        }
    }
}
