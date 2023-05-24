/*
ReadLine()  --> string
Read()  ---> int --> ascii code
ReadKey() --->  character
*/
using System;

public class standardInput
{
    public static void Main(string[] args){
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello,"+name);

        Console.WriteLine("Press any key to continue..... ");
        ConsoleKeyInfo key = Console.ReadKey();
        Console.WriteLine("Your press : {0}",key.Key);
    }

}