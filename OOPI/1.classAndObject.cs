using System;


class ClassObject
{
    //field --> variable
    class Dog{
        public string breed;

        public void bark(){
            Console.WriteLine("Bark Bark!!");
        }
    }
    //method
    public static void Main(string[] args){
        //create object
        Dog obj = new Dog();

        //access breed of the dog
        obj.breed = "Bull Dog";//assign
        Console.WriteLine(obj.breed);//access

        //access method of the dog
        obj.bark();
    }
}