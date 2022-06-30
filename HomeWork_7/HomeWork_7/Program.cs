using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            int Num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= Num; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
