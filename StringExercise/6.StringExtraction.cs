using System;

public class stringExtraction
{
    public static void Main(string[] args){
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        Console.Write("Enter the start position: ");
        int startPosition = int.Parse(Console.ReadLine());

        Console.Write("Enter the end position: ");
        int endPosition = int.Parse(Console.ReadLine());

        string extractedString = inputString.Substring(startPosition, endPosition - startPosition + 1);

        Console.WriteLine("Extracted String: " + extractedString);

        //khine // 1 3
        //public string Substring(int startIndex, int length)
    }
}