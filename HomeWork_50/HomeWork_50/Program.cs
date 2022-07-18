using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


namespace HomeWork_50
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
            int requestColumn = RequestNumberFirst();
            int requestStrin = RequestNumberSecond();
            PrintArray(NewArray);



            if (requestStrin > strin || requestColumn > column)
            {
                Console.WriteLine("Такой строки или элемента не существует");
            }
            else
            {
                Console.WriteLine("Значение элемента массива: "+NewArray[requestColumn,requestStrin]);
            }
            
        }
        static int[,] FillArray(int col, int str)
        {
            Random rnd = new Random();
            int[,] arr = new int[col, str];
            for(int i=0; i<col;i++)
            {
                for(int j=0; j<str; j++)
                {
                    arr[i,j] = rnd.Next(0, 30);
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
                    Console.Write(arr[i, j]+" ");
                    if (j == arr.GetLength(1)-1) Console.Write("]");

                }
                Console.WriteLine();
            }
        }
        static int RequestNumberFirst()
        {
            Console.WriteLine("Напишите номер строки, который нужно проверить");
            int numFirst = Convert.ToInt32(Console.ReadLine()) - 1;
            return numFirst;
        }
        static int RequestNumberSecond()
        {
            Console.WriteLine("Напишите номер элемента, который нужно проверить");
            int numSecond = Convert.ToInt32(Console.ReadLine()) - 1;
            return numSecond;
        }
    }
}
