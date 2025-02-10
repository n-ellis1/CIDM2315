namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
         {
        // Taking input from the user
        Console.Write("Input an integer: ");
        int N = int.Parse(Console.ReadLine());

        // Checking if the number is prime
        if (IsPrime(N))
        {
            Console.WriteLine($"{N} is prime");
        }
        else
        {
            Console.WriteLine($"{N} is non-prime");
        }
    }

    static bool IsPrime(int N)
    {
        // Handling special case for numbers less than 2
        if (N < 2)
        {
            return false;
        }

        // Loop from 2 to N-1 to check divisibility
        for (int i = 2; i <= Math.Sqrt(N); i++)
        {
            if (N % i == 0)
            {
                return false; // Found a divisor, N is not prime
            }
        }

        return true; // No divisors found, N is prime
        }

        
        //Question 2

         {
        // Taking input from the user
        Console.Write("Assign an int value to N: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++) // Outer loop for rows
        {
            for (int j = 0; j < N; j++) // Inner loop for columns
            {
                Console.Write("# "); // Print hashtag in each position
            }
            Console.WriteLine(); // Move to the next line after each row
            }
        }


        //Question 3

        {
        // Taking input from the user
        Console.Write("Assign an int value to N: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++) // i represents the current row
        {
            for (int j = 1; j <= i; j++) // j represents the current column
            {
                Console.Write("*"); // Print an asterisk
            }
            Console.WriteLine(); // Move to the next line after each row
            }
        }
    }
}
