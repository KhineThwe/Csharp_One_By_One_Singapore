using System;
using Internal;

public class exercise
{
    public static void Main(string[] args){
        int a = 5;
        int b = 5;
        bool check= !true;

        int preFixResult = ++a;
        Console.WriteLine("Prefix Increment: a = {0}",a);//a = 6
        Console.WriteLine("Prefix Result: {0}",preFixResult);//preFixResult = 6

        int postFixResult = b++;
        Console.WriteLine("Post Fix Result: {0}",postFixResult);//postFixResult = 5
        Console.WriteLine("PostFix Increment Result: b = {0}",b);//b= 6

        Console.WriteLine("Check result: {0}",check);
        
    }

}