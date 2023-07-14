using System;

public class protectedLesson
{
    class Student{
        protected string name = "Jame";
    }
    class Program : Student{
        public static void Main(string[] args){
            Program stu = new Program();

            Console.WriteLine("Name: " + stu.name);
        }
    }
}
//protected,it can only be accessed from the same class and its derived class.