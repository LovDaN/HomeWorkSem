using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int strin = 4;
            int column = 4;
            int[,]volumeArray = new int[strin,column];
            int[,] resultArray = FillMatrix(volumeArray, strin, column);
            PrintMatrix(resultArray);

        }
        static void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j]/10 == 0) Console.Write("0"+arr[i, j]);
                    else Console.Write(arr[i,j]);
                    if (j < arr.GetLength(1) - 1) Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static int[,] FillMatrix(int[,] arr, int strin, int col)
        {
            int count = 1;
            int i=0;
            int j=0;
           for(j = 0; j<col-1;j++)
            {
                arr[i, j] = count++;

            }
           for (i =0; i<strin-1;i++)
            {
                arr[i,j] = count++;
            }
           for (j=3; j>0;j--)
            {
                arr[i, j] = count++;
            }
            for (i = 3; i > 1; i--)
            {
                arr[i, j] = count++;
            }
            for (j = 0; j < 2; j++)
            {
                arr[i, j] = count++;
            }
            for (i = 1; i < 2; i++)
            {
                arr[i, j] = count++;
            }
            for (j = 2; j > 0; j--)
            {
                arr[i, j] = count++;
            }
            return arr;
        }
    }
}
