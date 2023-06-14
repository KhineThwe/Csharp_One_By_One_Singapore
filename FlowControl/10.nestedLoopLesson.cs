using System;
using Internal;
/*
A loop within another loop ---> nested loop

Outer-loop
{
//body of outer-loop
Inner-loop
{
//body of inner-loop
}
}
*/
public class nestedLoopStatement
{
    public static void Main(string[] args){
          int outerLoop = 0,innerLoop = 0;
          for(int i=1;i<=5;i++)
          {
              outerLoop++;
              for(int j=1;j<=5;j++){
                innerLoop++;
              }
          }
          Console.WriteLine("Outer Loop runs {0} times",outerLoop);
          Console.WriteLine("Inner Loop runs {0} times",innerLoop);
    }
}