using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите размеры массива");
            Console.WriteLine("Укажите кол-во строк в массиве");
            int strin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите кол-во столбцов массива");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] matrixOne = FillMatrix(strin, column);
            PrintMatrix(matrixOne);
            Console.WriteLine("Укажите размеры массива №2");
            Console.WriteLine("Укажите кол-во строк в массиве");
            int column2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите кол-во столбцов массива");
            int strin2 = Convert.ToInt32(Console.ReadLine());
            int[,] matrixTwo = FillMatrix(strin2, column2);
            PrintMatrix(matrixTwo);
            Console.WriteLine();
            if (column == strin2)
            {
                int[,] resultMatrix = MultiplicationMatrix(matrixOne, matrixTwo, column, strin2);
                PrintMatrix(resultMatrix);
            }
            else
            {
                Console.WriteLine("Умножение не возможно");
            }
        }
        static int[,] FillMatrix(int col, int str)
        {
            Random rnd = new Random();
            int[,] arr = new int[str, col];
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = rnd.Next(0, 10);
                }
            }
            return arr;
        }
        static void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j == 0) Console.Write("[");
                    Console.Write(arr[i, j]);
                    if (j < arr.GetLength(1) - 1) Console.Write(" ");
                    if (j == arr.GetLength(1) - 1) Console.Write("]");

                }
                Console.WriteLine();
            }
        }
        static int[,] MultiplicationMatrix(int[,] matrFirst, int[,] matrSecond, int col, int str)
        {
            int[,] resultMatrix = new int[matrFirst.GetLength(0),matrSecond.GetLength(1)]; 
            for(int i = 0; i<str; i++)
            {
                for (int j =0; j<col; j++)
                {
                    for(int k =0; k<matrSecond.GetLength(1); k++)
                    {
                        resultMatrix[i, j] += matrFirst[i, k] * matrSecond[k, j];
                    }
                   

                }
            }
            return resultMatrix;
        }


    }
}
