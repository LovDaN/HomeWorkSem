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
            Console.WriteLine("Добро пожаловать в Tetris!");
            Console.WriteLine("Чтобы поиграть используйте NUM PUD");
            Console.WriteLine("Для управления единичкой используйте клавиши 1,2 и 3");
            Console.WriteLine("1 <--  "+"2 Вниз  "+"3 -->");
            Console.WriteLine("Для продолжения нажмите на любую клавишу");
            Console.ReadKey();
            Console.Clear();
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
                CheckEnd(field);
                int key = Convert.ToInt32(Console.ReadLine());
                if (key == 1 || key == 2 || key == 3)
                {
                    switch (key)
                    {
                        case 2:
                            ++count;
                            count = SwitchDown(field, count, strin);
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
                            ++count;
                            count = SwitchDown(field, count, strin);
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    ++count;
                    count = SwitchDown(field, count, strin);
                    Console.Clear();
                }
                
                PrintArray(field);
            }
            
        }
        static int SwitchDown(int[,] arr, int n, int j)
        {
            
            arr[n, j] = 1;
            arr[n-1, j] = 0;
            if (arr[n + 1, j] == 2)
            {
                arr[n, j] = 2;
                n = 0;
            }
            return n;
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
        static void CheckEnd(int[,] arr)
        {
            for(int i=0;i<arr.GetLength(1);i++)
            {
                if (arr[1, i] == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Game Over");
                }
            }
        }


    }
                   
}
