using System;
using Internal;

public class breakWhile
{
    public static void Main(string[] args){
        int i = 1;
        while(i<=5){
            Console.WriteLine(i);
            i++;
            if(i==4){
                break;
            }
        }
        Console.ReadLine();
          
    }
}