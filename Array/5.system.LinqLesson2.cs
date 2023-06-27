using System;
using System.Linq;
using Internal;
/*
Methods to perform various operations in an array.
*/

public class Average
{
    public static void Main(string[] args){
        int[] numbers = { 51, 1, 3, 4, 98 };

        //get sum
        float sum = numbers.Sum();

        //count
        int count = numbers.Count();

        float average = sum / count;

        Console.WriteLine("Average Value: " + average);

        //compute the average
        Console.WriteLine("Average using Average(): " + numbers.Average());

        Console.ReadLine();
    }
}