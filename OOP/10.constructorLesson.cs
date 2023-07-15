using System;
using Internal;

//1.Parameterless Constructor
//2.Parameterized Constructor
//3.Default Constructor --> with empty code and no parameters
//Car(){

//}
public class constructorLesson
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