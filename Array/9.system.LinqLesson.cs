using System;
using System.Linq;
using Internal;

public class arrayLesson1
{
    public static void Main(string[] args){
        //create an array
        string[] names = { "Alice", "Bob", "Charlie","Dave","Eve"};

        //Filtering with Where() and Length
        var longNames = names.Where(name => name.Length > 4);
        Console.WriteLine("Long Names: ");
        foreach(var name in longNames){
            Console.WriteLine(name);
        }
        Console.WriteLine();

        //Sorting with OrderBy()
        var sortedNames = names.OrderBy(name => name);
        Console.WriteLine("Sorted Names: ");
        foreach(var name in sortedNames){
            Console.WriteLine(name);
        }
        Console.WriteLine();
    }
}