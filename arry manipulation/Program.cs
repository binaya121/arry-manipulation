using System;

namespace ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize an array to store the numbers
            int[] numbers = new int[10];

            // Prompt the user to enter 10 numbers
            Console.WriteLine("Enter 10 numbers, one at a time:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number {i + 1}: ");

                if (int.TryParse(Console.ReadLine(), out int userInput))
                {
                    numbers[i] = userInput;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    i--; // Decrement i to re-enter the current number
                }
            }

            // Modify the values of the array
            for (int i = 0; i < 10; i++)
            {
                // Check if the index is not zero to avoid division by zero
                if (i != 0)
                {
                    numbers[i] = numbers[i] / (i + 1);
                }
            }

            // Print the new values
            Console.WriteLine("Modified values of the array:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Wait for user input to exit
            Console.ReadLine();
        }
    }
}
