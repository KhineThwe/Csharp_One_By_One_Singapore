using System;
namespace CsharpNestedClass{
    //outer class
    class Computer{
        public void display(){
            Console.WriteLine("Method of Computer Cass");
        }

        //inner class
        public class CPU{
            public void innerDisplay(){
                Console.WriteLine("Method of Inner CPU Class ");
            }
        }
    }

    class Laptop : Computer{

    }

    class Desktop: Computer.CPU{

    }

    class Program{
        static void Main(string[] args){
            Laptop laptop = new Laptop();
            laptop.display();

            Desktop desktop = new Desktop();
            desktop.innerDisplay();
        }
    }
}