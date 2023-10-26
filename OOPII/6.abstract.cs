using System;

namespace AbstractClass{
    abstract class Animal{

        //abstract method 
        public abstract void makeSound();//prototype
        //non-abstract method 
        public void display(){
            Console.WriteLine("Non abstract method");
        }
    }

    //inherting from abstract class 
    class Dog : Animal{
        public override void makeSound(){
            Console.WriteLine("Bark");
        }
    }

     class Cat : Animal{
        public override void makeSound(){
            Console.WriteLine("Meow");
        }
    }

    class Program{
        static void Main(string[] args){
            Dog obj = new Dog();
            obj.makeSound();
            obj.display();


            Cat cat = new Cat();
            cat.makeSound();

        }
    }
}