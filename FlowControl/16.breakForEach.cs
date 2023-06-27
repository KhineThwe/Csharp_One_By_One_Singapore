using System;
using Internal;

public class breakForEach
{
    public static void Main(string[] args){
        int[] num = { 1, 2, 3, 4, 5, 6 };

        //for each loop
        foreach(int n in num){
            if(n == 3){
                break;
            }
        Console.WriteLine(n);
        }
    }
}