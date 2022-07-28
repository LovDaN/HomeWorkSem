using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Задайте число N: ");
            int number = Convert.ToInt32(Console.ReadLine());
            FindNaturalNumber(number);
        }
        static void FindNaturalNumber(int num)
        {
            if (num == 0) return;
            Console.Write($"{num}  ");
            FindNaturalNumber(num-1);
        }
    }
}
