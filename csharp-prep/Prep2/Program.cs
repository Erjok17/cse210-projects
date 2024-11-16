using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // This is to ask the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        // This is to Initialize variables
        string letter = "";
        string sign = "";

        // to Determine the letter grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // This is to Determine the sign (+, -, or nothing)
        if (letter != "A" && letter != "F")
        {
            int lastDigit = gradePercentage % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A")
        {
            int lastDigit = gradePercentage % 10;
            if (lastDigit >= 7)
            {
                sign = "";
            }
        }
        else
        {
            // There are no sign for F grades
            sign = "";
        }

        // To Display the grade with sign
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // To Check if the user passed or failed
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Better luck next time.");
        }
    }

}
