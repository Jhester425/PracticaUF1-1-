using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter their name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Prompt the user to enter their age
        Console.Write("Enter your age: ");
        // We use int.TryParse to handle cases where the user enters a non-integer value
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            // Display a greeting with the entered name and age
            Console.WriteLine($"Hello, {name}! You are {age} years old.");
        }
        else
        {
            // Display an error message if the entered age is not a valid integer
            Console.WriteLine("Invalid age. Please enter a valid number.");
        }

        // Wait for the user to press Enter before closing the console window
        Console.ReadLine();
    }
}
