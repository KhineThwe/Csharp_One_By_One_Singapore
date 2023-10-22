using System;
//access modifier returnType methodName(Parameters){//method header
//method body
//}
public class methodLesson
{
    // int sum = 0;
    class Program{
        int sum;
        //method declaration
        public void display(){
            Console.WriteLine("Hello");
        }
        public int addNumbers(int a,int b){
            sum = a + b;
            return sum;
        }
    }
    public static void Main(string[] args){
        //obj
        Program p1 = new Program();
        p1.display();
        // int result = p1.addNumbers(10, 20);
        Console.WriteLine( p1.addNumbers(10, 20));
    }
}