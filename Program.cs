using System;

namespace myParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("How many random numbers do you want to generate?");
            int numValues = int.Parse(Console.ReadLine());

            int[] numbers = new int[numValues];
            for (int i = 0; i < numValues; i++)
            {
                numbers[i] = rand.Next(1, 101); // Generate random numbers between 1 and 100
            }

            Console.WriteLine("Random numbers:");
            for (int i = 0; i < numValues; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine($"Sum: {Add(numbers)}");
            Console.WriteLine($"Product: {Multiply(numbers)}");
        }

        static int Add(params int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            return total;
        }

        static int Multiply(params int[] numbers)
        {
            int total = 1; // Initialize total to 1 for multiplication
            foreach (int num in numbers)
            {
                total *= num;
            }
            return total;
        }
    }
}
