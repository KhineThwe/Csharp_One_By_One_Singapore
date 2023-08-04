using System;
using Internal;

public class ThisKeyword
{
   class Test{
        int num1;
        int num2;

       public Test(){
            num1 = 22;
            num2 = 33;
        }
        
        //method that accepts this as argument
        public void passParameter(Test t1){
            Console.WriteLine("num1 : " + num1);
            Console.WriteLine("num2 : " + num2);
        }

        public void display(){
            passParameter(this);
        }
     public static void Main(string[] args){
            Test t1 = new Test();
            t1.display();
            
        }
   }
}