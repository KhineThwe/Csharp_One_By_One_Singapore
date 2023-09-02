using System;

public class StringExercise1
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first string: ");
        string firstString = Console.ReadLine();

        Console.Write("Enter the second string: "); 
        string secondString = Console.ReadLine();

        string concatenatedString = firstString + secondString;

        Console.WriteLine("Concatenated String: " + concatenatedString);
    }
}
