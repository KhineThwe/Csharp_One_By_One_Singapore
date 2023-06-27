using System;

/*
Array Declaration

1.dataType[] arrayName = new dataType[size];
eg. int[] age = new int[5];
2.dataType[] arrayName = {data1,data2,...};
eg. int[] numbers = {1,2,3,4,5};
3.Accessing array
#with index no
*/
//Change array
public class arrayLesson2
{
    public static void Main(string[] args){
        //create an array
        int[] numbers = { 1, 2, 3 };

       //0ld value
        Console.WriteLine("Old value at index 0: "+ numbers[0]);

        //change the value at index 0
        numbers[0] = 11;

        //new value
        Console.WriteLine("New value at index 0: "+ numbers[0]);
    }
}