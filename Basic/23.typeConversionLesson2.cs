/*
Convert.ToBoolean,Convert.ToDouble,Convert.ToString,Convert.ToInt32,Convert.ToInt64
*/
using System;
using System.Runtime;
using Internal;

public class typeConversionMethod
{
    public static void Main(string[] args){
        int myInt = 10;
        double myDouble = 5.25;
        bool myBool = true;
        
        string newInt = Convert.ToString(myInt);

        Console.WriteLine(newInt);
        Console.WriteLine(newInt.GetType());
        Console.WriteLine(Convert.ToDouble(myInt));
        Console.WriteLine(myInt.GetType());
        Console.WriteLine(Convert.ToInt32(myDouble));
        Console.WriteLine(myDouble.GetType());
        Console.WriteLine(Convert.ToString(myBool));
        Console.WriteLine(myBool.GetType());              
    }
}