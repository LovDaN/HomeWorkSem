using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать!");
            double[] pointsArr = InputValues();
            double[] resultArr = FindPoints(pointsArr);
            PrintResult(resultArr);
       
        }
        static double[] InputValues()
        {
            Console.WriteLine("Введите по порядку точки b1, k1, b2 и k2");
            double[] arr = new double[4];
            for(int i = 0; i<arr.Length;i++)
            {
                Console.WriteLine("Введите точку " + (i + 1));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            return arr;
        }
        static void PrintResult(double[] arr)
        {
            if (((arr[0]) - (arr[1])) == 0)
            {
                Console.WriteLine("Точка пересечения на координатах (" + arr[0] + ", " + arr[1] + ")");
            }
            else
            {
                Console.WriteLine("Точки пересечения не существует.");
            }
        }
        static double[] FindPoints(double[] arr)
        {
            double[] pointsArr = new double[2];
            pointsArr[0] =(arr[0] - arr[2]) / ((arr[1] - arr[3])*-1);
            pointsArr[1] = arr[3] * (pointsArr[0]) + (arr[2]);
            return pointsArr;
        }

    }
}
