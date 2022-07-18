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
            Console.WriteLine("Для управления единичкой используйте клавиши (стрелочки)");
            Console.WriteLine("Влево <--  "+"Вниз Стрелочка Вниз или любая клавиша  "+"Вправо -->");
            Console.WriteLine("Для выхода из программы нажмите клавишу Esc");
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
            ConsoleKeyInfo cki;


            do
            {
                CheckEnd(field);
                cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.DownArrow)
                {
                    count++;
                    count = SwitchDown(field, count, strin);
                    Console.Clear();
                }
                else if (cki.Key == ConsoleKey.LeftArrow)
                {
                    strin--;
                    strin = SwitchLeft(field, count, strin);
                    Console.Clear();
                }
                else if (cki.Key == ConsoleKey.RightArrow)
                {
                    strin++;
                    strin = SwitchRight(field, count, strin);
                    Console.Clear();
                }
                else
                {
                    ++count;
                    count = SwitchDown(field, count, strin);
                    Console.Clear();
                }           
                PrintArray(field);
            }while (cki.Key != ConsoleKey.Escape);
            
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
        static int SwitchLeft(int[,] arr, int n, int j)
        {
            if (j - 1 < 0) j = 0;
            
            arr[n, j] = 1;
            arr[n, j + 1] = 0;
            if (arr[n, j - 1] == 2) j++;
            return j;
        }
        static int SwitchRight(int[,] arr, int n, int j)
        {
            if (j + 1 > 10) j = 10;
            else if (arr[n, j+1] == 2) j--;
            arr[n, j] = 1;
            arr[n, j - 1] = 0;
            return j;
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
