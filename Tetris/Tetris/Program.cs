using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] field = new int[,]
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
            };
            PrintArray(field);
            int count = 0;
            int strin = 4;
            


            while (true)
            {
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 2:
                        ++count;
                        if (count == 17) count = 0;
                        SwitchDown(field, count, strin);
                        Console.Clear();
                        break;
                    case 1:
                        strin--;
                        SwitchLeft(field, count, strin);
                        Console.Clear();
                        break;
                    case 3:
                        strin++;
                        SwitchRight(field, count, strin);
                        Console.Clear();
                        break;
                    default:
                        SwitchDown(field, count, strin);
                        Console.Clear();
                        break;
                }
                PrintArray(field);
            }
            
        }
        static void SwitchDown(int[,] arr, int n, int j)
        {
            
            arr[n, j] = 1;
            arr[n-1, j] = 0;

        }
        static void SwitchLeft(int[,] arr, int n, int j)
        {
            arr[n, j] = 1;
            arr[n, j+1] = 0;
        }
        static void SwitchRight(int[,] arr, int n, int j)
        {
            arr[n, j] = 1;
            arr[n, j-1] = 0;
        }
        static void PrintArray(int[,] arr)
        {
            for(int i=0; i<arr.GetLength(0); i++)
            {
                for(int j=0; j<arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        static int Refund(int number, int[,] arr)
        {
            arr[0, 5] = 1;
            return number;
        }

    }
                   
}
