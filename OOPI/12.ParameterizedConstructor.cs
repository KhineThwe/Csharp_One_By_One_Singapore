using System;
//Constructor Overloading
public class ParameterizedConstructor
{
    public class Car{
        public string brand;
        public int price;

        //Parameterized Constructor

        public Car(){
            Console.WriteLine("No Argument constructor");
        }

        public Car(string theBrand){
            brand = theBrand;
        }

        public Car(int thePrice){
            price = thePrice;
        }
        public Car(string theBrand,int thePrice){
            brand = theBrand;
            price = thePrice;
        }

        public Car(int thePrice,string theBrand){
            price = thePrice;
            brand = theBrand;
        }
    }
    public static void Main(string[] args){
        Car car1 = new Car();

        Car car2 = new Car("Toyota");
        Console.WriteLine("Brand: " + car2.brand);

        Car car3 = new Car(100000000);
        Console.WriteLine("Price: " + car3.brand);

        Car car4 = new Car("Bugatti", 50000);
        Console.WriteLine("Brand: " + car4.brand);
        Console.WriteLine("Price: " + car4.price);

        Car car5 = new Car(50000,"jj");
        Console.WriteLine("Brand: " + car5.brand);
        Console.WriteLine("Price: " + car5.price);
    }
}