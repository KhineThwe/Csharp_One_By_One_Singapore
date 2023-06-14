/*
while(test-expression){
    //body of while
    //increment or decrement
}
*/
using System;
using Internal;

public class whileStatement
{
    public static void Main(string[] args){
          int i = 1;
          while(i<=5){
            Console.WriteLine("C# For Loop: Iteration"+i);
            i++;
          }
    }
}