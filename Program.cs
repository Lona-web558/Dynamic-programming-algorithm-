using System;

class Program
{
    static int FibonacciDP(int n)
    {
        if (n <= 1)
            return n;

        int[] dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }

        return dp[n];
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the number of Fibonacci terms to calculate: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"The {n}th Fibonacci number is: {FibonacciDP(n)}");

        Console.WriteLine("\nFibonacci sequence up to the {0}th term:", n);
        for (int i = 0; i <= n; i++)
        {
            Console.Write(FibonacciDP(i) + " ");
        }
    }
}