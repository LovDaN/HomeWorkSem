using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во чисел в массиве");
            int count = Convert.ToInt32(Console.ReadLine());
            double[] myArray = new double[count];
            double[] resArray = NewArray(myArray);
            PrintArray(resArray);
            Console.WriteLine();
            double minNumber = MinNumArr(resArray);
            double maxNumber = MaxNumArr(resArray); 
            double result = MinusArr(maxNumber,minNumber);
            Console.WriteLine("Результат вычисления = "+result);

            
        }
        static double[] NewArray(double[] arr)
        {
            Random rnd = new Random();
            
            for (int i=0; i<arr.Length; i++)
            {
                arr[i] = Math.Round(rnd.NextDouble(),2);
                
            }
            return arr;
        }
        static void PrintArray(double[] arr)
        {
            for (int i=0; i<arr.Length; i++)
            {
                if (i == 0) { Console.Write("["); }

                Console.Write(arr[i] + " ");

                if (i == arr.Length - 1) { Console.Write("]"); }
            }
        }
        static double MinNumArr(double[] arr)
        {
            double minValue = arr[0];
            for (int i = 0;i<arr.Length;i++)
            {
                if (arr[i]<minValue)
                {
                    minValue = arr[i];
                }

            }
            return minValue;
        }
        static double MaxNumArr(double[] arr)
        {
            double maxValue = 0;
            for (int i = 0; i<arr.Length;i++)
            {
                if (arr[i]>maxValue)
                {
                    maxValue = arr[i];
                }
            }
            return maxValue;
        }
        static double MinusArr(double maxNum, double minNum)
        {
            double result = maxNum - minNum;
            return result;
        }
    }
}
