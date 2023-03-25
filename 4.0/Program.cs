using System;

class Program
{
    static void Main(string[] args)
    {
        double number;

        while (true)
        {
            Console.Write("Enter a number : ");

            if (double.TryParse(Console.ReadLine(), out number))
            {
                if (number % 1 == 0 || number % 1 != 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        Console.WriteLine($"Integers in the range [1, 100] that are divisible by {number}:");
        for (int i = 1; i <= 100; i++)
        {
            if (i % number == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
