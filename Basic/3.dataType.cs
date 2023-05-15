/*
int
double 
char  --> 'a'
string --> 'apple'
bool

Other Data Types
------------------------
1.byte       8-bit unsigned int 0 to 255
2.char       16-bit unicode character
3.sbyte      8-bit signed int -128 to 127
4.short      16-bit signed int -32,768 to 32,767
5.uint       32-bit unsigned int 0 to 4,294,967,295
6.ulong      64bit unsigned int 0 to 18,446,744,073,709,551,615
7.ushort    16-bit unsigned int 0 to 65535
*/
using System;
using Internal;

public class dataType
{
    public static void Main(string[] args){
        string name = "Khine";
        int age = 24;
        double salary = 3.0;
        bool isActive = true;
        char gender = 'F';

        Console.WriteLine("Name:"+name);
        Console.WriteLine("Age:"+age);
        Console.WriteLine("Salary:"+salary);
        Console.WriteLine("Is Active:"+isActive);
        Console.WriteLine("Gender:"+gender);

    }

}