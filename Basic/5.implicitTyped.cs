using System;
using Internal;

public class implicitDataType
{
    public static void Main(string[] args){
        var i = 5;
        Console.WriteLine(i);
        Console.WriteLine(i.GetType());

        var s = "Khine";
        Console.WriteLine(s);
         Console.WriteLine(s.GetType());

        var a = new[] {0,1,2,3,4};
        Console.WriteLine(a.GetType());
    }

}