using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов, стоящих на нечётных позициях.
            //[3, 7, 23, 12] -> 19
            //[-4, -6, 89, 6]-> 0

            Console.WriteLine("Введите кол-во значений для массива");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] myArr = new int[count];
            int[] resArr = NewArray(myArr);
            PrintArr(resArr);
            Console.WriteLine();
            SumOddPosArr(resArr);
        }
        static int[] NewArray(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
            return arr;
        }
        static void SumOddPosArr(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum = arr[i]+sum;
                }


            }
            Console.WriteLine("Сумма чисел на нечетных позициях массива (" + sum + ") ");
        }
        static void PrintArr(int[] arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0) { Console.Write("["); }
                Console.Write(arr[i] + " ");
                
                if (i == arr.Length-1) { Console.Write("]"); }
                
                
            }
            
        }
    }
}    

