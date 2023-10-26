using System;

namespace AbstractClass{
    abstract class Animal{
        protected string name;

        //abstract method 
        public abstract string Name{
            get;
            set;
        }
    }

    //inherting from abstract class 
    class Dog : Animal{
        public override string Name{
            get{
                return name;
            }
            set{
                name = value;
            }
        }
    }
    class Program{
        static void Main(string[] args){
            Dog obj = new Dog();
            obj.Name = "Khine";
            Console.WriteLine("Name: " + obj.Name);
        }
    }
}