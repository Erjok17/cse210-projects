using System;

class Program
{
    static void Main(string[] args)
    {
        

         // I will Call DisplayWelcome function to greet the user
        DisplayWelcome();

        // Calling the PromptUserName to get the user's name
        string userName = PromptUserName();

        // Calling the  PromptUserNumber to get the user's favorite number
        int favoriteNumber = PromptUserNumber();

        // Calling the SquareNumber to calculate the square of the number
        int squaredNumber = SquareNumber(favoriteNumber);

        // Calling DisplayResult to display the user's name and the squared number
        DisplayResult(userName, squaredNumber);
    }

    /// <summary>
    /// Displays a welcome message.
    /// </summary>
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    /// <summary>
    /// Asking the the user for their name and returning it as a string.
    /// </summary>
    /// <returns> Returns the user's name.</returns>
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    /// <summary>
    /// Asking the user for their favorite number and returning it as an integer.
    /// </summary>
    /// <returns>It returns user's favorite number.</returns>
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    /// <summary>
    /// Accepts an integer and returns its square.
    /// </summary>
    /// <param name="number">The number to square.</param>
    /// <returns>The squared number.</returns>
    static int SquareNumber(int number)
    {
        return number * number;
    }

    /// <summary>
    /// Displaying the user's name and the squared number.
    /// </summary>
    /// <param name="userName">The user's name.</param>
    /// <param name="squaredNumber">The squared number.</param>
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
    
}