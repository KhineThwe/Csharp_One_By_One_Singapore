/*
in C#, two ---> implicit casting(auto) --> smaller type ---> larger type
char --> int ---> long --> float ---> double

---> explicit casting(manually) --> larger type ---> smaller type
double ---> float --> long ---> int --> char 
       
*/
using System;
using Internal;

public class typeCasting
{
    public static void Main(string[] args){
        //implicit casting
        int myInt = 9;
        double myDouble = myInt; //automatic casting : int to double 
        Console.WriteLine(myInt);
        Console.WriteLine(myDouble);

        //explicit casting
        double myDouble1 = 9.78;
        int myInt1 = (int)myDouble1;//manual casting : double to int
        Console.WriteLine(myInt1);
        Console.WriteLine(myDouble1);
    }

}