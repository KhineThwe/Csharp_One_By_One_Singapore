using System;

namespace Inheritance{
    //base class
    class Animal {
        public string name = "Bird";

        public void display() {
            Console.WriteLine("I am an animal.");
    }
    }
    

    class Dog : Animal {
        public void getName(){
            Console.WriteLine("My name is " + name);
        }
    }

    class Program{
        public static void Main(string[] args){
            Animal a = new Animal();
            Console.WriteLine(a.name);
            a.display();

            Dog d = new Dog();
            d.display();
            d.getName();
        }
    }
}