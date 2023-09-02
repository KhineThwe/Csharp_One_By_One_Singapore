using System;

public class stringReverse
{
    public static void Main(string[] args){
        Console.Write("Enter a string");
        string inputString = Console.ReadLine();

        //khine   ----> enihk
        //convert string to char array
        //C# built-in method Reverse use
        char[] charArray = inputString.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);//charArray to string
        Console.WriteLine("Reversed String: " + reversedString);
    }
}