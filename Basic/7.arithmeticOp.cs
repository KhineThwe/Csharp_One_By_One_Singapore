/*
Arithmetic Operators 
+ 
-
*
/
% 
*/
using System;
using Internal;

public class ArithmeticOp
{
    public static void Main(string[] args){
        double firstNumber = 14.40,secondNumber=4.60,result=0;

        result = firstNumber+secondNumber;
        Console.WriteLine("{0}+{1} = {2}",firstNumber,secondNumber,result);


        result = firstNumber-secondNumber;
        Console.WriteLine("{0}-{1} = {2}",firstNumber,secondNumber,result);


        result = firstNumber*secondNumber;
        Console.WriteLine("{0}*{1} = {2}",firstNumber,secondNumber,result);

        result = firstNumber/secondNumber;
        Console.WriteLine("{0}/{1} = {2}",firstNumber,secondNumber,result);

        result = firstNumber%secondNumber;
        Console.WriteLine("{0}%{1} = {2}",firstNumber,secondNumber,result);
    }

}