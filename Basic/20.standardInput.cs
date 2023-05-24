/*
int.Parse() method
int.TryParse() method
Convert.ToInt32() 
*/
using System;


public class standardInput2
{
    public static void Main(string[] args){

        Console.WriteLine("Please enter two numbers: ");

        Console.Write("First Number: ");
        string input1 = Console.ReadLine();
        int number1 = int.Parse(input1);

        Console.Write("Second Number: ");
        string input2 = Console.ReadLine();
        int number2 = int.Parse(input2);

        int sum = number1 + number2;
        Console.WriteLine("The sum of {0} and {1} is {2}",number1,number2,sum);
    }

}