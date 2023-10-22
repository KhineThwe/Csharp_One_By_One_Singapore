using System;
using Internal;

public class VariableScopeExample
{
    class Program{
        public static void Main(string[] args){
            int x = 10;
            if(x>5){
                int y = 10;
                Console.WriteLine("x:" + x);//x = 10
                Console.WriteLine("y:" + y);//y =10
            }

            // Console.WriteLine("y: " + y);//y = error

            Console.WriteLine("x: " + x);//x = 10

        }
    }
   
}