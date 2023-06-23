using System;
using Internal;

public class nestedDoWhileLoop
{
    public static void Main(string[] args){
          int outerCount = 1;

          do{
            int innerCount = 1;
            do{
                Console.WriteLine("Outer Count: "+outerCount+"Inner Count: "+innerCount);
                innerCount++;
            }while(innerCount<=3);//Inner loop Condition
            outerCount++;
          }while(outerCount<=3);//Outer loop Condition
    }
}