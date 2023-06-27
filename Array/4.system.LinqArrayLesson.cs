using System;
using System.Linq;
using Internal;
/*
Methods to perform various operations in an array.
*/

public class ArrayMinMax
{
    public static void Main(string[] args){
        int[] numbers = { 51, 1, 3, 4, 98 };

        //get minimum element 
        Console.WriteLine("Smallest Element: " + numbers.Min());

         //get maximum element 
        Console.WriteLine("Biggest Element: " + numbers.Max());
    }
}