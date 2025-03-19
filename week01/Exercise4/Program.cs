using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 0)
            {
                // Stop if the user enters 0
                break;
            }
            // Add the number to the list
            numbers.Add(input);
        }


        if (numbers.Count > 0)
        {
            // Compute the sum
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            // Compute the average
            double average = (double)sum / numbers.Count;

            // Find the maximum number
            int maxNumber = numbers[0];
            foreach (int number in numbers)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            // Display the results
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {maxNumber}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}