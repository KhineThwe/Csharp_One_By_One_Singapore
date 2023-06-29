using System;
using Internal;

public class forEachLesson
{
    public static void Main(string[] args){
        char[] myArray = { 'H', 'e', 'l', 'l', 'o' };

        // for (int i = 0; i < myArray.Length;i++){
        //     Console.WriteLine(myArray[i]);
        // }
        foreach(char ch in myArray){
            Console.WriteLine(ch);
        }
        /*
        foreach(elementType element in arrayname){
            //code
        }
        */
    }
}