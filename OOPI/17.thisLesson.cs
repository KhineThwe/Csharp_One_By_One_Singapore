using System;
using Internal;

public class ThisKeyword
{
   class Test{

    Test(int num1,int num2){
            Console.WriteLine("Constructor with two parameters");
        }
     
    Test(int num) : this(33,22){
            Console.WriteLine("Constructor with one parameter");
        }
     public static void Main(string[] args){
            Test t1 = new Test(11);
        }
   }
}