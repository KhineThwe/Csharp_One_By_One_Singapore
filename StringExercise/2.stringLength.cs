using System;

public class StringExercise2
{
    public static void Main(string[] args){
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        int length = inputString.Length;

        Console.WriteLine("Length of the string: " + length);
    }
}