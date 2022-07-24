using System;


namespace HomeWork_60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите размеры массива");
            Console.WriteLine("Укажите объем массива");
            int volume = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите кол-во строк массива");
            int strin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите кол-во колонок массива");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,,] volumeArray = FillArray(volume, strin, column);
            PrintArray(volumeArray, volume);

        }
        static int[,,] FillArray(int vol, int str, int col)
        {
            Random rnd = new Random();
            int[,,] arr = new int[vol, str, col];
            int v = 0;
            int j;
            for (int i=0; i < str; i++)
            {
                if (v == vol) break;
                for (j = 0; j < col; j++)
                {
                    arr[v,i, j] = rnd.Next(10, 100);
                }
                if (i == arr.GetLength(1)-1)
                {
                    v++;
                    i = -1;
                    j = -1;
                }
            }
            return arr;
        }
        static void PrintArray(int[,,] arr, int vol)
        {
            int v = 0;
            int j;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if(v == vol) break;
                for (j = 0; j < arr.GetLength(2); j++)
                {                   
                    Console.Write(arr[v, i, j] + " (" + v+" "+i+" "+j+")");
                    if (j < arr.GetLength(2) - 1) Console.Write(" ");
                }
                Console.WriteLine();
                if(i == arr.GetLength(1)-1)
                {
                    v++;
                    i = -1;
                    j = -1;
                }
            }
        }
    }
}
