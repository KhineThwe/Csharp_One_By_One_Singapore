using System;

public class defaultConstructor
{
    class Program{
        int a;
        public static void Main(string[] args){
            //call default constructor
            Program p1 = new Program();

            Console.WriteLine("Default value of a: " + p1.a);

        }
    }
}