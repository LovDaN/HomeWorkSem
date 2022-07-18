using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


namespace HomeWork_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк в массиве m");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во значений в строке массива n");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] twoDimensionalArr = FillArray(m,n);
            PrintArray(twoDimensionalArr);

        }
        static double[,] FillArray(int m, int n)
        {
            double[,] array = new double[m, n];
            Random rnd = new Random();
            for(int i = 0; i<m;i++)
            {
                for(int j = 0; j<n;j++)
                {
                    array[i, j] = Math.Round(rnd.NextDouble(), 2);
                }
            }
            return array;
        }
        static void PrintArray(double[,] array)
        {
            for(int i=0; i<array.GetLength(0); i++)
            {
                for(int j=0; j<array.GetLength(1); j++)
                {
                    if (j == 0) { Console.Write("[");}
                    Console.Write($"{array[i, j]} ");
                    if (j == array.GetLength(1)-1) { Console.Write("]");}
                    
                }
                Console.WriteLine();
            }
        }
    }
}
