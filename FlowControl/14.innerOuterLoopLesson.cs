using System;
using Internal;

public class innerOuterLoopLesson
{
    public static void Main(string[] args){
          int i = 1;
          while(i<=5){
            for(int j=1;j<=i;j++){
                Console.Write(i+" ");
            }
            Console.WriteLine();
            i++;
          }
    }
}