using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задайте массив заполненный случайными положительными трёхзначными числами.Напишите программу, которая покажет количество чётных чисел в массиве.
            //[345, 897, 568, 234] -> 2
            Console.WriteLine("Введите кол-во значений для массива");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] myArr = new int[count];
            int[] resArr = NewArray(myArr);
            PrintArr(resArr);
            Console.WriteLine();
            PosNumArr(resArr);
        }
        static int[] NewArray(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 1000);
            }
            return arr;
        }
        static void PosNumArr(int[] arr)
        {
            int count = 0;
            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
                

            }
            Console.WriteLine("Кол-во четных чисел массива ("+count+") ");
        }
        static void PrintArr (int[] arr)
        {
            for (int i = 0;i<arr.Length ; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
