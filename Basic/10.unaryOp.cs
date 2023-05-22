/*
Unary Operator
---------------
for only single operand
+        Unary Plus 
-        Unary Minus
++       Increment 
--       Decrement
//!        Logical Not 
----------------------
++,--  ---> prefix , postfix
*/
using System;
using Internal;

public class unaryOp
{
    public static void Main(string[] args){
        int number = 10,result;
        bool flag =true;
        result  = +number;
        Console.WriteLine("+number = {0}",result);

        result  = -number;
        Console.WriteLine("-number = {0}",result);

        result  = ++number;
        //prefix Increment
        Console.WriteLine("++number = {0}",result);

        result  = --number;
        //prefix Decrement
        Console.WriteLine("--number = {0}",result);
        //number = 10
        result  = number++;
        //postfix Increment
        Console.WriteLine("number++ = {0}",result);//10
        //number = 11

        result  = number--;//number => number = 10
        //postfix Decrement
        Console.WriteLine("number-- = {0}",result);//
        Console.WriteLine("Real number = {0}",number);
    }
}
