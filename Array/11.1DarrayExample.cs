using System;

public class array2DLesson2
{
    public static void Main(string[] args)
    {
        int[,] X;
        X = new int[2, 3];
        Console.Write("Enter Elements: \n");

        for (int i = 0; i < X.GetLength(0); i++)
        {
            for (int j = 0; j < X.GetLength(1); j++)
            {
                Console.Write("\tElement[" + i + "," + j + "]: ");
                X[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("\n\nElements are: \n");

        for (int i = 0; i < X.GetLength(0); i++)
        {
            for (int j = 0; j < X.GetLength(1); j++)
            {
                Console.Write(X[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}

