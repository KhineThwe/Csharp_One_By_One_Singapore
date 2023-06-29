using System;
using System.Collections.Generic;
using Internal;

public class array2DLesson
{
    public static void Main(string[] args){
        List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

        foreach(string name in names){
            Console.WriteLine(name);
        }

        string[] fruits = { "Apple", "Banana", "Orange" };
        foreach(string fruit in fruits){
            Console.WriteLine("I love" + fruit);
        }
    }
}