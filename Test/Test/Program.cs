using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dom6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначное число");
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                string strNumber = number.ToString();
                

                if (strNumber.Length == 4)
                {
                    int a = strNumber[strNumber.Length - 1];
                    Console.WriteLine("Число: " + number);
                    Console.WriteLine("Последнее " + a);
                    int b = strNumber[strNumber.Length];
                    Console.WriteLine("Первое " + b);
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Это число не трёхзначное. Введите трёхзначное число");
                }
            }
            
            
        }
    }
}
