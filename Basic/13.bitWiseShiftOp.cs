/*
~   Bitwise Complement   -(n+1)
&   Bitwise And
|   Bitwise OR
^   Bitwise Exclusive OR
<<  Bitwise Left Shift
>>  Bitwise Right Shift
*/
using System;
using Internal;

public class BitwiseOp
{
    public static void Main(string[] args){
        int firstNumber = 14;
        int secondNumber = 11;
        int result=0;

        result = ~firstNumber;
        Console.WriteLine("~{0} = {1}",firstNumber,result);

        result = firstNumber & secondNumber;
        Console.WriteLine("{0} & {1} ={2}",firstNumber,secondNumber,result);

        result = firstNumber | secondNumber;
        Console.WriteLine("{0} | {1} ={2}",firstNumber,secondNumber,result);

        result = firstNumber ^ secondNumber;
        Console.WriteLine("{0} & {1} ={2}",firstNumber,secondNumber,result);

        result = firstNumber << 2;
        Console.WriteLine("{0} << 2 ={1}",firstNumber,result);

        result = firstNumber >> 2;
        Console.WriteLine("{0} >> 2 ={1}",firstNumber,result);
    }

}