using System;
using Internal;

public class ifStatement
{
    public static void Main(string[] args){
        int number = 20 ;
        if (number < 5){
            Console.WriteLine("{0} is less than 5",number);
        }
        Console.WriteLine("This statement is always executed.");
    }

}