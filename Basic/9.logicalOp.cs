/*
OR ||
AND & 
*/
using System;
using Internal;

public class dataType
{
    public static void Main(string[] args){
        bool result;
        int firstNumber = 10,secondNumber = 20;
        
        //OR operator
        result = (firstNumber == secondNumber) || (firstNumber > 5);
        Console.WriteLine(result);

        //AND operator
        result = (firstNumber == secondNumber) && (firstNumber > 5);
        Console.WriteLine(result);
        
    }

}