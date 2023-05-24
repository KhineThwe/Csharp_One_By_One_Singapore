/*
=>      Lambda Operator  x=>x*x    Return x*x

(parameters) => expression or statement block

The two types of lambda expressions are:

Expression Lambda
Statement Lambda
*/
using System;
using Internal;

public class lambdaOperator
{
    public static void Main(string[] args){
        /*statement lambda*/
        int result = Multiply(5,3,(x,y) => x*y)  ;
        Console.WriteLine("Result: "+result);

    }

    public static int Multiply(int a,int b,Func<int,int,int> multiplyFunc){
        return multiplyFunc(a,b);
    }

}