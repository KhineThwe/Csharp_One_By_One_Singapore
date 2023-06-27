using System;
using Internal;

//Iterating C# Array using Loops
public class AccessArrayFor
{
    public static void Main(string[] args){
        //create an array
        int[] numbers = { 1, 2, 3 };

        for (int i = 0; i < numbers.Length;i++){
            Console.WriteLine("Element in index" + i + ":" + numbers[i]);
        }

        Console.ReadLine();
    }
}