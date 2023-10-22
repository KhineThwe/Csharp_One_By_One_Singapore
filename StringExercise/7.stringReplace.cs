using System;

public class stringReplace
{
    public static void Main(string[] args){
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        Console.Write("Enter a substring: ");
        string subString = Console.ReadLine();

        Console.Write("Enter the replacement string: ");
        string replacementString = Console.ReadLine();

        string modifiedString = inputString.Replace(subString, replacementString);
        Console.WriteLine("Modified String: " + modifiedString);
    }
}