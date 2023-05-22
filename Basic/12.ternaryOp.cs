/*
variable = Condition?Expression1:Expression2
*/
using System;
using Internal;

public class ternaryOp
{
    public static void Main(string[] args){
        int number = 10;
        string result;

        result = (number %2 ==0)?"Even Number":"Odd Number";
        Console.WriteLine("{0} is {1}",number,result);
    }

}