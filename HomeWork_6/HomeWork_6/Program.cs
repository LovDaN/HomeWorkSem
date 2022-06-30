using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Введите число для проверки");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("Число четное.");
                }
                else
                {
                    Console.WriteLine("Число не четное.");
                }
                Console.ReadKey();
            }
            
        }
    }
}
