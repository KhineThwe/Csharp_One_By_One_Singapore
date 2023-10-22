using System;

namespace methodOverriding
{
    // Base class
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Food");
        }
    }

    // Derived class of Animal
    class Dog : Animal
    {
        // Overriding method from Animal
        public override void Eat()
        {
            Console.WriteLine("I eat Dog Food");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Eat();
        }
    }
}
