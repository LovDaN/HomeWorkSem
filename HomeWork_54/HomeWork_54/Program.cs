using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите размеры массива");
            Console.WriteLine("Укажите кол-во строк в массиве");
            int column = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите кол-во символов в строке массива");
            int strin = Convert.ToInt32(Console.ReadLine());
            int[,] NewArray = FillArray(column, strin);
            PrintArray(NewArray);
            Console.WriteLine();
            int[,] resultArray = SortMatrix(NewArray);
            PrintMatrix(resultArray);
        }
        static int[,] FillArray(int col, int str)
        {
            Random rnd = new Random();
            int[,] arr = new int[col, str];
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < str; j++)
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
        static int[,] SortMatrix(int[,] array)
        {
            for (int l = 0; l < array.GetLength(0); l++)
            {
                for(int i = 1; i < array.GetLength(1); i++)
                {
                    int current = array[l,i];
                    int j = i;
                    while (j > 0 && current < array[l,j - 1])
                    {
                        array[l,j] = array[l,j - 1];
                        j--;
                    }
                    array[l,j] = current;
                }
                
            }
            return array;
            
            

        }

    }
}
