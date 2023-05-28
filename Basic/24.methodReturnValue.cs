using System;
using Internal;

public class methodReturnValue
{
    public static void Main(string[] args){ 
        int result=Add(4,5);
        Console.WriteLine("Result is {0}",result);
    }

    public static int Add(int num1,int num2){
        return num1 + num2;
    }
}