using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_56
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
            int[,] NewMatrix = FillMatrix(column, strin);
            PrintMatrix(NewMatrix);
            FindStringMinSumElem(NewMatrix);
        }
        static int[,] FillMatrix(int col, int str)
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
        static void FindStringMinSumElem(int[,] arr)
        {
            int current = 0;
            int min = 0;
            int count = 0;
           for(int i = 0; i < arr.GetLength(0); i++)
            {
                current = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    current += arr[i, j];
                }
                
                if(min > current || i==0)
                {
                    min = current;
                    count++;
                }
                
            }
            Console.WriteLine("Минимальная сумма элементов строки№: "+count+" = "+min);
        }
    }
}
