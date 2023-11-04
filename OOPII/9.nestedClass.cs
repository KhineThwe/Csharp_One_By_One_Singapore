using System;
namespace CsharpNestedClass
{
    //outer class
    public class Car{
        public static string brand = "Bugatti";
        public void displayCar(){
            Console.WriteLine("Car : Honda");
        }

        //inner class 
        public class Engine{
            public void displayEngine(){
                Console.WriteLine("Engine: Petrol");
            }
            public void display(){
                Console.WriteLine("Brand : " + Car.brand);
            }
        }
    }

    public class Program {
        public static void Main(string[] args){
            //create object of outer class
            Car car = new Car();
            car.displayCar();

            //create object of inner Class
            Car.Engine engine = new Car.Engine();
            engine.displayEngine();
            engine.display();
        }
    }
    
}