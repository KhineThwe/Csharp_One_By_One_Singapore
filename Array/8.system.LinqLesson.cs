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

        //Mapping using Select()
        var squaredNumbers = numbers.Select(n => n * n);
        Console.WriteLine("Squared Numbers: ");
        foreach(var number in squaredNumbers){
            Console.WriteLine(number);
        }
        Console.WriteLine();
    }
}