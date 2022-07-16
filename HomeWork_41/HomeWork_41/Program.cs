using System;

namespace HomeWork_41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во чисел М");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] emptyArr = new int[count];
            int[] fullArr = InputArray(emptyArr);
            PrintArr(fullArr);
            Console.WriteLine();
            FindPositiveNums(fullArr);
            

        }
        static int[] InputArray(int[] arr)
        {

            for(int i = 0; i<arr.Length;i++)
            {
                Console.WriteLine("введите число " +(i+1));
                arr[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.Clear();
            return arr;
            
        }
        static void PrintArr(int[] arr)
        {
            for(int i = 0; i<arr.Length;i++)
            {
                if (i == 0) { Console.Write("[");}
                Console.Write(arr[i]);
                if (i < arr.Length-1) { Console.Write(", ");}
                if (i == arr.Length-1) { Console.Write("]");}
            }
        }
        static void FindPositiveNums(int[] arr)
        {
            int count=0;
            for( int i = 0; i < arr.Length;i++)
            {
                if(arr[i] > 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Положительных чисел до M = "+count);
        }
    }
}
