
using System;

namespace prime {
public class GFG {

	public static void SieveOfEratosthenes(int n)
	{

		bool[] prime = new bool[n + 1];

		for (int i = 0; i <= n; i++)
			prime[i] = true;

		for (int p = 2; p * p <= n; p++)
		{
			
			if (prime[p] == true)
			{
				for (int i = p * p; i <= n; i += p)
					prime[i] = false;
			}
		}

		for (int i = 2; i <= n; i++)
		{
			if (prime[i] == true)
				Console.Write(i + " ");
		}
	}

	public static void Main()
	{
		Console.WriteLine("Enter a number");
		int n = Convert.ToInt32(Console.ReadLine()); 
		Console.WriteLine(
			"Following are the prime numbers");
		Console.WriteLine("smaller than or equal to " + n);
		SieveOfEratosthenes(n);
	}
}
}


