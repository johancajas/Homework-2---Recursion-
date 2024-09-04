using System;

public class Program
{
    // Non-Recursive (Iterative) Version
    public static int PowerOf2Iterative(int n)  // Now public
    {
        int result = 1;
        for (int i = 0; i < n; i++)
        {
            result *= 2;  // Multiply result by 2 in each iteration
        }
        return result;
    }

    // Recursive Version
    public static int PowerOf2Recursive(int n)  // Now public
    {
        if (n == 0)
        {
            return 1;  // Base case: 2^0 = 1
        }
        else
        {
            return 2 * PowerOf2Recursive(n - 1);  // Recursive case
        }
    }

    // Main Method to Test Both Implementations
    public static void Main()  // Already public by default
    {
        int n = 3;

        int iterativeResult = PowerOf2Iterative(n);
        Console.WriteLine($"Iterative: 2^{n} = {iterativeResult}");

        int recursiveResult = PowerOf2Recursive(n);
        Console.WriteLine($"Recursive: 2^{n} = {recursiveResult}");
    }
}
