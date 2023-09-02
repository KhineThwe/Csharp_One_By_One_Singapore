using System;

public class stringReverseSimple
{
    public static void Main(string[] args){
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        string reversedString = "";//empty string
        //khine 
        //01234
        //5-1=4

        // for(int i=0;i<=inputString.Length;i++){
        //     Console.WriteLine(inputString[i]);
        // }

        for(int i=inputString.Length-1;i>=0;i--){
            reversedString += inputString[i];//e
            //enihk

        }
        Console.WriteLine("Reversed String: " + reversedString);

    }
}