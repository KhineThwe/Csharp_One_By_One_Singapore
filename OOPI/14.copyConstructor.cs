using System;
using System.Reflection;
using Internal;

public class copyConstructor
{
    class Car{
        string brand;
        
        //constructor 
        Car(string theBrand){
            brand = theBrand;
        }

        //copy constructor
        Car(Car c1){
            brand = c1.brand;
        }
        public static void Main(string[] args){
            //constructor
            Car car1 = new Car("Toyota");
            Console.WriteLine("Brand of car1: " + car1.brand);

            //call the copy constructor
            Car car2 = new Car(car1);
            Console.WriteLine("Brand of car2: " + car2.brand);
        }
    }
}