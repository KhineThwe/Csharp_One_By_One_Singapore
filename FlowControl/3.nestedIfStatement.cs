using System;
using Internal;

public class nestedIfStatement
{
    public static void Main(string[] args){
          int num = 10;
          if(num > 0){
            Console.WriteLine("Number is positive.");
            if(num %2 == 0){
                Console.WriteLine("Number is even.");
            }else{
                Console.WriteLine("Number is odd.");
            }
          }else if(num < 0){
            Console.WriteLine("Number is negative.");
          }else{
            Console.WriteLine("Number is zero.");
          }
    }
}