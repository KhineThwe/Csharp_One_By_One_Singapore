using System;

namespace Inheritance{
    //base class
    class Animal {
        public string name = "Bird";

        protected void display() {
            Console.WriteLine("I am an animal.");
    }
    }
    class Dog : Animal {
        public static void Main(string[] args){
            Dog d = new Dog();
            //access protected method from base class
            d.display();
        }
    }
 
}