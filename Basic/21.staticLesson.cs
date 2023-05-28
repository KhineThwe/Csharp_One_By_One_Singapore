using System;
using Internal;

public class staticLesson
{
    static float tax = 19f;
    public static void Main(string[] args){
        float tax = 16f;
        Calculate(tax);
    }

    public static void Calculate(float tax){
        Console.WriteLine("Tax Value : {0}",tax);
    }
}