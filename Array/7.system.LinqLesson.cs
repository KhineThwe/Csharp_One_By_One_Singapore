using System;
using System.Linq;
using Internal;
/*
Methods to perform various operations in an array.
*/
public class Lesson
{
    public static void Main(string[] args){
        int[] numbers = {1,2,3,4,5};

        //Example 1: Filtering using Where()
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Even Numbers: ");
        foreach(var number in evenNumbers){
            Console.WriteLine(number);
        }
        Console.WriteLine();
    }
}