/*
while(condition-1){
    //body of outer while loop
    while(condition-2){
        //body of inner while loop
    }
    //body of outer while loop
}
*/
using System;
using Internal;

public class nestedWhileStatement
{
    public static void Main(string[] args){
          int i = 0;
          while(i<2){
            int j = 0;
            while(j<2){
                int k = i + j;
                
                Console.WriteLine(k);
                
                j++;
            }
            i++;
            Console.WriteLine();
          }
    }
}