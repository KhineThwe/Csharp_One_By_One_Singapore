using System;
using System.Collections.Generic;
using Internal;

public class array2DLesson
{
    public static void Main(string[] args){
        Dictionary<int, string> students = new Dictionary<int, string>{
        {1,"Alice"},
        {2,"Bob"},
        {3,"Charlie"}
       };

       foreach(KeyValuePair<int,string> student in students){
            Console.WriteLine("ID: " + student.Key + ", Name: " + student.Value);
        }
    }
}