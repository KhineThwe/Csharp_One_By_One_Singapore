using System;
namespace CsharpNestedClass
{
    public class Car
    {
        public void displayCar()
        {
            Console.WriteLine("Car : Toyota");
        }

    public class Engine
       {
        public void displayEngine()
        {
           Console.WriteLine("Engine : Petrol");
        }
        }
    }

class Program{
    public static void Main(string[] args){
        Car car = new Car();
        car.displayCar();

        Car.Engine engine = new Car.Engine();
        engine.displayEngine();
    }
}
}