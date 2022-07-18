using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_52
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
            Console.WriteLine("Укажите номер столбца, для нахождения среднего арифметического");
            int requestString = Convert.ToInt32(Console.ReadLine())-1;
            FindArithmeticMean(NewArray, requestString);
            
            
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
        static void PrintArray(int[,] arr)
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
        static void FindArithmeticMean(int[,] arr, int num)
        {
            double count = 0;
            double result = 0;
            Console.Write("Среднее арифметическое строки #" + (num+1)+": ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(num+","+i);
                if (i < arr.GetLength(0) - 1) Console.Write(" ");
                result = arr[i,num] + result;
                count++;
            }
            result = Math.Round(result / count ,2);
            Console.Write(" = "+result);
            Console.WriteLine();
        }
    }
}
