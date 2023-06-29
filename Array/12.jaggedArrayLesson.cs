using System;
using Internal;

public class jaggedArrayLesson
{
    public static void Main(string[] args){
        //declare
        int[][] jagged_arr = new int[4][];

        //Initialize the elements
        jagged_arr[0] = new int[] { 1, 2, 3, 4 };
        jagged_arr[1] = new int[] { 11, 34, 67 };
        jagged_arr[2] = new int[] { 89, 23 };
        jagged_arr[3] = new int[] { 0, 45, 78, 53, 99 };

        for (int n = 0; n < jagged_arr.Length;n++){
            Console.WriteLine("Row({0})" + n);

            for (int k = 0; k < jagged_arr[n].Length;k++){
                Console.WriteLine("{0}", jagged_arr[n][k]);
            }
            Console.WriteLine();
        }

    }
}