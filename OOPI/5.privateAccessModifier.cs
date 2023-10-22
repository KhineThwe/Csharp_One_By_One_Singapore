using System;

//private access modifier --> it can only be accessed within the same class
public class privateAccessModifier
{
    class Student{
        private string name = "C#";

        public void print(){
            Console.WriteLine("Hello From Student Class" +name);
        }
    }
    class Program{
        public static void Main(string[] args){
            Student stu1 = new Student();
            // Console.WriteLine("Name:" + stu1.name);

            stu1.print();
        }
    }
}
//error