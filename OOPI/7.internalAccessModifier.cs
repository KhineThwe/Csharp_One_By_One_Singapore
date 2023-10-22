using System;
using Internal;

namespace Assembly{
    class Student{
        internal string name = "KZT";
    }
    class Program{
        static void Main(string[] args){
            Student stu = new Student();

            Console.WriteLine("Name: " + stu.name);
        }
    } 
}