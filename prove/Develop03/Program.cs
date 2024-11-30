using System;

class Program
{
    static void Main(string[] args)
{
    Console.WriteLine("Hello Develop03 World!");

    string filePath = "scriptures.txt";

    // Check if the file exists
    if (!File.Exists(filePath))
    {
        Console.WriteLine($"Error: File '{filePath}' not found.");
        return; // Exit the program
    }

    // Load scriptures from the file
    string[] scriptures = File.ReadAllLines(filePath);

    if (scriptures.Length == 0)
    {
        Console.WriteLine("Error: The file is empty.");
        return; // Exit the program
    }

    Random random = new Random();
    string chosenScripture = scriptures[random.Next(scriptures.Length)];

    // Split the scripture into reference and text
    string[] parts = chosenScripture.Split('|');
    if (parts.Length < 2)
    {
        Console.WriteLine("Error: Invalid scripture format in file.");
        return; // Exit the program
    }

    Reference reference = ParseReference(parts[0]);
    Scripture scripture = new Scripture(reference, parts[1]);

    // Main program loop
    Console.Clear();
    Console.WriteLine(scripture);
    while (!scripture.IsCompletelyHidden())
    {
        Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
        string input = Console.ReadLine();

        if (input.ToLower() == "quit")
        {
            break;
        }

        scripture.HideRandomWords(2); // Hide 2 words at a time
        Console.Clear();
        Console.WriteLine(scripture);
    }

    Console.WriteLine("\nAll words are hidden. The program has ended.");
}
private static Reference ParseReference(string referenceString)
{
    try
    {
        string[] parts = referenceString.Split(':');
        if (parts.Length != 2)
        {
            throw new FormatException("Reference must contain a book, chapter, and verse.");
        }

        string bookAndChapter = parts[0].Trim();
        string[] verseParts = parts[1].Trim().Split('-');

        string[] bookChapterParts = bookAndChapter.Split(' ');
        if (bookChapterParts.Length != 2)
        {
            throw new FormatException("Book and chapter must be separated by a space.");
        }

        string book = bookChapterParts[0];
        int chapter = int.Parse(bookChapterParts[1]);

        if (verseParts.Length == 1)
        {
            return new Reference(book, chapter, int.Parse(verseParts[0]));
        }
        else if (verseParts.Length == 2)
        {
            return new Reference(book, chapter, int.Parse(verseParts[0]), int.Parse(verseParts[1]));
        }
        else
        {
            throw new FormatException("Invalid verse format.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error parsing reference: {ex.Message}");
        throw; // Rethrow exception to indicate a serious error
    }
}

}