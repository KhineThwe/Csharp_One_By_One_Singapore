using System;
using Internal;

public class ThisKeyword
{
   class Test{
        int num;

        Test(int number){
            this.num = number;
            Console.WriteLine("object of this: " + this.num);
        }
        public static void Main(string[] args){
            Test t1 = new Test(4);
            Console.WriteLine("object of t1" + t1.num);

        }
   }
}