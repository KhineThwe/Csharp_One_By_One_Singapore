using System;
using Internal;

public class ifelseStatement
{
    public static void Main(string[] args){
        int number = 12;
        if(number < 5){
            Console.WriteLine("{0} is less than 5",number);
        }else if(number > 5 ){
            Console.WriteLine("{0} is greater than or equal to 5",number);
        }else{
            Console.WriteLine("This statement is always executed.");
        }     
    }
}