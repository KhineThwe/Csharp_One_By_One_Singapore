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
public class arrayLesson1
{
    public static void Main(string[] args){
        //create an array
        int[] numbers = { 1, 2, 3 };

        //access first element
        Console.WriteLine("Element in first index: "+ numbers[0]);

        //access last element
        Console.WriteLine("Element in first index: "+ numbers[2]);
    }
}