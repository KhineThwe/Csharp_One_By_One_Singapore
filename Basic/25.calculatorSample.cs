using System;
using Internal;

public class calculatorProgram
{
    public static void Main(string[] args){
        Console.WriteLine("Welcome to the Calculator Program!");

        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Select an operation: ");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)");

        Console.WriteLine("Enter the operation number: ");
        int operation = Convert.ToInt32(Console.ReadLine());

        double result = 0;

        switch(operation){
            case 1:
               result = num1 + num2;
               break;
            case 2:
               result = num1 - num2;
               break;
            case 3:
               result = num1 * num2;
               break;
            case 4:
               if (num2 != 0)
                   result = num1 / num2;
               else 
                   Console.WriteLine("Error: Division By zero!");
               break;
            default:
               Console.WriteLine("Invalid operation number!");
               break;
        }
        Console.WriteLine("The result is : {0}",result);
        Console.WriteLine("Thank you for using the Calculator Program!");
    }

}