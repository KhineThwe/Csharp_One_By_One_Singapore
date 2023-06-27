using System;
using System.Linq;
using Internal;

public class Lesson
{
    public static void Main(string[] args){
        //create an array
        int[] numbers = { 1, 2, 3,4,5};

        //checking if any element satisfies a condition with Any()
        bool hasEvenNumber = numbers.Any(n => n % 2 == 0);
        Console.WriteLine("Has even number?" + hasEvenNumber);
        Console.WriteLine();
    }
}