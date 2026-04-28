using System;

public class ClassEx7
{
	public static bool checkPrimes(int x)
	{
        bool check = true; //primes
        if (x <=1)
            return false;
        if (x > 3)
        {
            for (int j = 2; j < Math.Sqrt(x); j++)
            {
                if (x % j == 0)
                {
                    check = false;
                }
            }
        }
        return check;
    }

	public static void Main()
	{
		Console.Write("Input number: ");
		int n = int.Parse(Console.ReadLine());

		Console.WriteLine("All Primes up to N: ");
		for(int i=2; i<=n; i++)
		{
            if (checkPrimes(i))
            {
                Console.Write(i + " ");
            }
        }
	}
}
