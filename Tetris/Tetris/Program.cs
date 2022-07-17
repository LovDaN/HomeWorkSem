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
                { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
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
            int num = 1;
            int count = 0;
            


            while (true)
            {
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        if (count == 17)
                        {
                            num = 3;
                            num = Refund(num, field);
                            Console.Clear();
                            break;
                        }
                        count++;
                        SwitchDown(field);
                        Console.Clear();
                        break;
                    default:
                        SwitchDown(field);
                        break;
                }
                PrintArray(field);
            }
            
        }
        static void SwitchDown(int[,] arr)
        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                
                for ( int j = 0; j < arr.GetLength(1); j++)
                {
                    
                    if (arr[i, j] == 1)
                    {
                        arr[i, j] = 0;
                        i++;
                        arr[i, j] = 1;
                        break;
                    }
                    
                    
                }
            }
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
