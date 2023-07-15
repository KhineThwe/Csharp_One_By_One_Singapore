using System;

public class ParameterizedConstructor
{
   public class Car{
    //parameterless constructor
    public Car(){
            Console.WriteLine("Car Constructor");
        }

    }
    public static void Main(string[] args){
        //call constructor
       Car car = new Car();
    }
}