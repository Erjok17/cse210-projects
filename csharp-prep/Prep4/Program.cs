using System;

class Program
{
    static void Main(string[] args)
    {
        

        // In the first Create an empty list to store the numbers
        List<int> numbers = new List<int>();

        // In the second step ask the user to enter numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number;
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            // Adding the number to the list if it's not a 0
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        // In the third step Compute and display the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        // In the fourth Compute and display the average
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // In the 5th  Find and display the largest number
        int max = int.MinValue;
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        // The stretch Challenge 1: Find the smallest positive number
        int? smallestPositive = null;
        foreach (int num in numbers)
        {
            if (num > 0 && (smallestPositive == null || num < smallestPositive))
            {
                smallestPositive = num;
            }
        }

        if (smallestPositive != null)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }

        // In the second strectch challenge Sort the list and display it
        numbers.Sort(); // This Sorts the list in ascending order
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
    
}