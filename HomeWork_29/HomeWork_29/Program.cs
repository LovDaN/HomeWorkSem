using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[8];
            int[] result = RandArr(myArray);
            PrintArr(result);
        }
        static int[] RandArr(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 2);
            }
            return arr;
        }
        static void PrintArr(int[] arr)
        {
            for (int i = 0;i < arr.Length;i++)
            {
                Console.Write(arr[i]);
                Console.WriteLine();
            }
            
        }
        
    }
}
